using System;
using System.Collections.Generic;

namespace Server.BusinessModels
{
    public class DebitCardCredential
    {
        public DebitCardCredential()
        {
            AccountFields = new HashSet<AccountField>();
        }

        public int DebitCardNumber { get; set; }
        public DateTime DebitCardExpiry { get; set; }
        public int DebitCardCvv { get; set; }

        public virtual ICollection<AccountField> AccountFields { get; set; }
    }
}
