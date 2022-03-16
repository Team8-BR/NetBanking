using System;

namespace server.BusinessModels
{
    public class CreditCardCredential
    {
        public int CreditCardNumber { get; set; }
        public DateTime CreditCardExpiry { get; set; }
        public int CreditCardCvv { get; set; }
    }
}
