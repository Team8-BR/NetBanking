using System;

namespace server.BusinessModels
{
    public class NetBankingCredential
    {
        public int UserId { get; set; }
        public int NetBankingPassword { get; set; }
        public int TransactionPassword { get; set; }
        public string AccountNumber { get; set; }
    }
}
