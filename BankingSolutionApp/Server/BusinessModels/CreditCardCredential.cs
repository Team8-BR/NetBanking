using System;
using System.Collections.Generic;

namespace Server.BusinessModels
{
    public class CreditCardCredential
    {
        public CreditCardCredential()
        {
            AccountFields = new HashSet<AccountField>();
        }

        public int CreditCardNumber { get; set; }
        public DateTime CreditCardExpiry { get; set; }
        public int CreditCardCvv { get; set; }

        public virtual ICollection<AccountField> AccountFields { get; set; }
    }
}
