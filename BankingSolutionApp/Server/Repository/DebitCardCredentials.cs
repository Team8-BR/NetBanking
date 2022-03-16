using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class DebitCardCredentials
    {
        public DebitCardCredentials()
        {
            AccountFields = new HashSet<AccountFields>();
        }

        public int DebitCardNumber { get; set; }
        public DateTime DebitCardExpiry { get; set; }
        public int DebitCardCvv { get; set; }

        public virtual ICollection<AccountFields> AccountFields { get; set; }
    }
}
