using System;
using System.Collections.Generic;

namespace Server.BusinessModels
{
    public class NetBankingCredential
    {
        public NetBankingCredential()
        {
            AccountFields = new HashSet<AccountField>();
        }

        public int UserId { get; set; }
        public int NetBankingPassword { get; set; }
        public int TransactionPassword { get; set; }
        public string AccountNumber { get; set; }

        public virtual AccountField AccountNumberNavigation { get; set; }
        public virtual ICollection<AccountField> AccountFields { get; set; }
    }
}
