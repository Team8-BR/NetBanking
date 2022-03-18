using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class BankCredentials
    {
        public BankCredentials()
        {
            AccountFields = new HashSet<AccountFields>();
        }

        public int CredentialId { get; set; }
        public int? UserId { get; set; }
        public int? NetBankingPassword { get; set; }
        public int? TransactionPassword { get; set; }
        public long? AccountNumber { get; set; }
        public decimal? AccountBalance { get; set; }
        public long? DebitCardNumber { get; set; }
        public DateTime? DebitCardExpiry { get; set; }
        public int? DebitCardCvv { get; set; }
        public int? DebitCardPin { get; set; }
        public long? CreditCardNumber { get; set; }
        public DateTime? CreditCardExpiry { get; set; }
        public int? CreditCardCvv { get; set; }
        public int? CreditCardPin { get; set; }

        public virtual ICollection<AccountFields> AccountFields { get; set; }
    }
}
