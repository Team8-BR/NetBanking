using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.EntityModels
{
    public partial class NetBankingCredentials
    {
        public int UserId { get; set; }
        public string NetBankingPassword { get; set; }
        public string TransactionPassword { get; set; }
        public string AccountNumber { get; set; }

        public virtual TransactionDetails AccountNumberNavigation { get; set; }
    }
}
