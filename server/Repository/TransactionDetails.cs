using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.Repository
{
    public partial class TransactionDetails
    {
        public TransactionDetails()
        {
            NetBankingCredentials = new HashSet<NetBankingCredentials>();
        }

        public string TransactionReferenceId { get; set; }
        public string AccountNumber { get; set; }
        public string RecipientAccountNumber { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public decimal? Transactionamount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int ModeId { get; set; }
        public string Remark { get; set; }

        public virtual ICollection<NetBankingCredentials> NetBankingCredentials { get; set; }
    }
}
