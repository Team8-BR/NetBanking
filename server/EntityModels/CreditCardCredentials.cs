using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.EntityModels
{
    public partial class CreditCardCredentials
    {
        public CreditCardCredentials()
        {
            AccountFields = new HashSet<AccountFields>();
        }

        public int CreditCardNumber { get; set; }
        public DateTime CreditCardExpiry { get; set; }
        public int CreditCardCvv { get; set; }

        public virtual ICollection<AccountFields> AccountFields { get; set; }
    }
}
