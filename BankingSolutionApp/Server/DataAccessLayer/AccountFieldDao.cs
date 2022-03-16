using Microsoft.EntityFrameworkCore;
using Server.BusinessModels;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.DataAccessLayer
{
    public class AccountFieldDao
    {
        public bool AddAccountDetail(AccountFields account)
        {
            bool status = false;

            try
            {
                using (var db = new BankingContext())
                {
                    db.AccountFields.Add(account);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }

        public List<AccountField> FetchAllAccount()
        {
            List<AccountField> businessDetails = null;
            try
            {
                using (var db = new BankingContext())
                {
                    DbSet<AccountFields> allAcc = db.AccountFields;
                    if (allAcc.Count() > 0)
                    {
                        businessDetails =
                            allAcc
                             .Select(
                                (AccountFields a) =>
                                     new AccountField
                                     {
                                         Title = a.Title,
                                         FirstName = a.FirstName,
                                         LastName = a.LastName,
                                         Mobileno = a.Mobileno,
                                         MiddleName = a.MiddleName,
                                         EmailId = a.EmailId,
                                         AadhaarCardNumber = a.AadhaarCardNumber,
                                         Dob = a.Dob,
                                         ReferenceId = a.ReferenceId,
                                         ResidentialAddressLine1 = a.ResidentialAddressLine1,
                                         ResidentialAddressLine2 = a.ResidentialAddressLine2,
                                         ResidentialCity = a.ResidentialCity,
                                         ResidentialLandmark = a.ResidentialLandmark,
                                         ResidentialPincode = a.ResidentialPincode,
                                         ResidentialState = a.ResidentialState,
                                         PermanentAddressLine1 = a.PermanentAddressLine1,
                                         PermanentAddressLine2 = a.PermanentAddressLine2,
                                         PermanentCity = a.PermanentCity,
                                         PermanentLandmark = a.PermanentLandmark,
                                         PermanentPincode = a.PermanentPincode,
                                         PermanentState = a.PermanentState,
                                         AccountNumber = a.AccountNumber,
                                         Occupationdetails = a.Occupationdetails,
                                         OccupationType = a.OccupationType,
                                         Sourceofincome = a.Sourceofincome,
                                         GrossAnnualIncome = a.GrossAnnualIncome,
                                         UserId = a.UserId,
                                         DebitCardNumber = a.DebitCardNumber,
                                         CreditCardNumber = a.CreditCardNumber,
                                         Status = a.Status
                                     }
                             )
                             .ToList<AccountField>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountField FetchAccountById(int id)
        {
            AccountField businessDetails = null;
            try
            {
                using (var db = new BankingContext())
                {
                    DbSet<AccountFields> alldetails = db.AccountFields;
                    var matchingAccount = alldetails.Where(p => p.ReferenceId == id);
                    if (matchingAccount != null && matchingAccount.Count() > 0)
                    {
                        AccountFields p = matchingAccount.First<AccountFields>();
                        businessDetails = new AccountField
                        {

                            Title = p.Title,
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            Mobileno = p.Mobileno,
                            MiddleName = p.MiddleName,
                            EmailId = p.EmailId,
                            AadhaarCardNumber = p.AadhaarCardNumber,
                            Dob = p.Dob,
                            ReferenceId = p.ReferenceId,
                            ResidentialAddressLine1 = p.ResidentialAddressLine1,
                            ResidentialAddressLine2 = p.ResidentialAddressLine2,
                            ResidentialCity = p.ResidentialCity,
                            ResidentialLandmark = p.ResidentialLandmark,
                            ResidentialPincode = p.ResidentialPincode,
                            ResidentialState = p.ResidentialState,
                            PermanentAddressLine1 = p.PermanentAddressLine1,
                            PermanentAddressLine2 = p.PermanentAddressLine2,
                            PermanentCity = p.PermanentCity,
                            PermanentLandmark = p.PermanentLandmark,
                            PermanentPincode = p.PermanentPincode,
                            PermanentState = p.PermanentState,
                            AccountNumber = p.AccountNumber,
                            Occupationdetails = p.Occupationdetails,
                            OccupationType = p.OccupationType,
                            Sourceofincome = p.Sourceofincome,
                            GrossAnnualIncome = p.GrossAnnualIncome,
                            UserId = p.UserId,
                            DebitCardNumber = p.DebitCardNumber,
                            CreditCardNumber = p.CreditCardNumber,
                            Status = p.Status
                        };
                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool InsertAccountField(AccountField p )
        {
            int result = 0;
            try
            {
                using (var db = new BankingContext())
                {
                    DbSet<AccountFields> allAccount = db.AccountFields;
                    AccountFields entityModelObject = new AccountFields
                    {
                            Title = p.Title,
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            Mobileno = p.Mobileno,
                            MiddleName = p.MiddleName,
                            EmailId = p.EmailId,
                            AadhaarCardNumber = p.AadhaarCardNumber,
                            Dob = p.Dob,
                            ReferenceId = p.ReferenceId,
                            ResidentialAddressLine1 = p.ResidentialAddressLine1,
                            ResidentialAddressLine2 = p.ResidentialAddressLine2,
                            ResidentialCity = p.ResidentialCity,
                            ResidentialLandmark = p.ResidentialLandmark,
                            ResidentialPincode = p.ResidentialPincode,
                            ResidentialState = p.ResidentialState,
                            PermanentAddressLine1 = p.PermanentAddressLine1,
                            PermanentAddressLine2 = p.PermanentAddressLine2,
                            PermanentCity = p.PermanentCity,
                            PermanentLandmark = p.PermanentLandmark,
                            PermanentPincode = p.PermanentPincode,
                            PermanentState = p.PermanentState,
                            AccountNumber = p.AccountNumber,
                            Occupationdetails = p.Occupationdetails,
                            OccupationType = p.OccupationType,
                            Sourceofincome = p.Sourceofincome,
                            GrossAnnualIncome = p.GrossAnnualIncome,
                            UserId = p.UserId,
                            DebitCardNumber = p.DebitCardNumber,
                            CreditCardNumber = p.CreditCardNumber,
                            Status = p.Status
                        
                    };
                    allAccount.Add(entityModelObject);
                    result = db.SaveChanges();
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}
