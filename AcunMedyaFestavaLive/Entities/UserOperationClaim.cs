using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class UserOperationClaim
    {
        public int UserOperationClaimID { get; set; }
        public int OperationClaimId { get; set; }
        public int UserId { get; set; }
    }
}