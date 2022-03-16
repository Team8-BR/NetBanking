using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace server.EntityModels
{
    public partial class AccountFields
    {
        public AccountFields()
        {
            NetBankingCredentials = new HashSet<NetBankingCredentials>();
            TransactionDetails = new HashSet<TransactionDetails>();
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

        public virtual CreditCardCredentials CreditCardNumberNavigation { get; set; }
        public virtual DebitCardCredentials DebitCardNumberNavigation { get; set; }
        public virtual NetBankingCredentials User { get; set; }
        public virtual ICollection<NetBankingCredentials> NetBankingCredentials { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
