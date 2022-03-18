using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class AccountFields
    {
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public long Mobileno { get; set; }
        public string EmailId { get; set; }
        public long AadhaarCardNumber { get; set; }
        public DateTime Dob { get; set; }
        public string ResidentialAddressLine1 { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public string ResidentialLandmark { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialCity { get; set; }
        public int ResidentialPincode { get; set; }
        public string PermanentAddressLine1 { get; set; }
        public string PermanentAddressLine2 { get; set; }
        public string PermanentLandmark { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCity { get; set; }
        public int PermanentPincode { get; set; }
        public string Occupationdetails { get; set; }
        public string OccupationType { get; set; }
        public string Sourceofincome { get; set; }
        public decimal? GrossAnnualIncome { get; set; }
        public string Status { get; set; }
        public int? CredentialId { get; set; }
        public int? TransactionReferenceId { get; set; }

        public virtual BankCredentials Credential { get; set; }
        public virtual TransactionDetails TransactionReference { get; set; }
    }
}
