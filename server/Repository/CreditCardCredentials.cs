using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.Repository
{
    public partial class CreditCardCredentials
    {
        public int CreditCardNumber { get; set; }
        public DateTime CreditCardExpiry { get; set; }
        public int CreditCardCvv { get; set; }
    }
}
