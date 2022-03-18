using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class TransactionDetails
    {
        public TransactionDetails()
        {
            AccountFields = new HashSet<AccountFields>();
        }

        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int ModeId { get; set; }
        public string Remark { get; set; }
        public long AccountNumber { get; set; }
        public decimal Transactionamount { get; set; }
        public long RecipientAccountNumber { get; set; }
        public int TransactionReferenceId { get; set; }

        public virtual ModeOfTransaction Mode { get; set; }
        public virtual ICollection<AccountFields> AccountFields { get; set; }
    }
}
