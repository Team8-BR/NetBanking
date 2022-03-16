using System;

namespace server.BusinessModels
{
    public class DebitCardCredential
    {
        public int DebitCardNumber { get; set; }
        public DateTime DebitCardExpiry { get; set; }
        public int DebitCardCvv { get; set; }
    }
}
