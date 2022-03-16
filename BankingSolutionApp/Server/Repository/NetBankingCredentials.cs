using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class NetBankingCredentials
    {
        public NetBankingCredentials()
        {
            AccountFields = new HashSet<AccountFields>();
        }

        public int UserId { get; set; }
        public int NetBankingPassword { get; set; }
        public int TransactionPassword { get; set; }
        public string AccountNumber { get; set; }

        public virtual AccountFields AccountNumberNavigation { get; set; }
        public virtual ICollection<AccountFields> AccountFields { get; set; }
    }
}
