using System;
using System.Collections.Generic;

namespace Server.BusinessModels
{
    public class AccountField
    {
        public AccountField()
        {
            NetBankingCredentials = new HashSet<NetBankingCredential>();
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public int ReferenceId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobileno { get; set; }
        public string MiddleName { get; set; }
        public string EmailId { get; set; }
        public string AadhaarCardNumber { get; set; }
        public DateTime Dob { get; set; }
        public string ResidentialAddressLine1 { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public string ResidentialLandmark { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialCity { get; set; }
        public string ResidentialPincode { get; set; }
        public string PermanentAddressLine1 { get; set; }
        public string PermanentAddressLine2 { get; set; }
        public string PermanentLandmark { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentPincode { get; set; }
        public string Occupationdetails { get; set; }
        public string OccupationType { get; set; }
        public decimal? Sourceofincome { get; set; }
        public int? GrossAnnualIncome { get; set; }
        public int UserId { get; set; }
        public int DebitCardNumber { get; set; }
        public int CreditCardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }

        public virtual CreditCardCredential CreditCardNumberNavigation { get; set; }
        public virtual DebitCardCredential DebitCardNumberNavigation { get; set; }
        public virtual NetBankingCredential User { get; set; }
        public virtual ICollection<NetBankingCredential> NetBankingCredentials { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
