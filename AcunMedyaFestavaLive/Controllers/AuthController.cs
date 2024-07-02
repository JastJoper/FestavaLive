using AcunMedyaFestavaLive.DataAccess;
using AcunMedyaFestavaLive.Entities;
using AcunMedyaFestavaLive.Models;
using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Controllers
{
	public class AuthController : Controller
	{
		private readonly Context context = new Context();

		[HttpGet]
		public ActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public ActionResult SignUp(User user)
		{
			if (ModelState.IsValid)
			{
				context.Users.Add(user);
				context.SaveChanges();
				var claim = new UserOperationClaim { UserId = user.UserID, OperationClaimId = 1 };
				context.UserOperationClaims.Add(claim);
				context.SaveChanges();
				return RedirectToAction("SignIn", "Auth");
			}

			return View(user);
		}

		[HttpGet]
		public ActionResult SignIn()
		{
			return View();
		}

		[HttpPost]
		public ActionResult SignIn(UserLoginModel model)
		{
			if (ModelState.IsValid)
			{
				var user = context.Users.SingleOrDefault(u => u.UserName == model.UserName && u.Password == model.Password);

				if (user != null)
				{
					var userDal = new UserDal();
					var claims = userDal.GetClaims(user);
					var firstClaim = claims.FirstOrDefault();

					Session["UserId"] = user.UserID;
					Session["UserName"] = user.UserName;
					Session["ImageUrl"] = user.ImageUrl;
					Session["OperationClaimName"] = firstClaim?.ClaimName;

					if (firstClaim != null)
					{
						if (firstClaim.OperationClaimID == 1)
						{
							return RedirectToAction("MyTicketList", "MyTicket", new { area = "Member" });
						}
						else if (firstClaim.OperationClaimID == 2)
						{
							return RedirectToAction("TicketList", "Ticket", new { area = "Admin" });
						}
					}
				}
				ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
			}

			return View(model);
		}
	}
}
