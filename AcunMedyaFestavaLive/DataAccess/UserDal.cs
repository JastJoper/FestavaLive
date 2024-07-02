using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.DataAccess
{
    public class UserDal
    {
        Context context = new Context();
        public List<OperationClaim> GetClaims(User user)
        {

            var result = from uoc in context.UserOperationClaims
                         join oc in context.OperationClaims
                         on uoc.OperationClaimId equals oc.OperationClaimID
                         where uoc.UserId == user.UserID
                         select new
                         {
                             oc.OperationClaimID,
                             oc.ClaimName
                         };

            return result.ToList().Select(x => new OperationClaim
            {
                OperationClaimID = x.OperationClaimID,
                ClaimName = x.ClaimName
            }).ToList();


        }
    }
}