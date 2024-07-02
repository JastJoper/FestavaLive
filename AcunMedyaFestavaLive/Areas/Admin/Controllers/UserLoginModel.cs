using System.ComponentModel.DataAnnotations;

namespace AcunMedyaFestavaLive.Models
{
	public class UserLoginModel
	{
		[Required]
		[Display(Name = "Kullanıcı Adı")]
		public string UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Şifre")]
		public string Password { get; set; }
	}
}
