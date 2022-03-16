using Microsoft.EntityFrameworkCore;
using Server.BusinessModels;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.DataAccessLayer
{
    public class CreditCardCredentialDao
    {
        public bool InsertCreditCardDetails(CreditCardCredential creditCardDetails)
        {
            int result = 0;
            try
            {
                using(var db = new BankingContext())
                {
                    DbSet<CreditCardCredentials> allcreditCardCredentials = db.CreditCardCredentials;
                    CreditCardCredentials entityModelObject = new CreditCardCredentials
                    {
                        CreditCardNumber = creditCardDetails.CreditCardNumber,
                        CreditCardExpiry = creditCardDetails.CreditCardExpiry,
                        CreditCardCvv = creditCardDetails.CreditCardCvv,
                        CreditCardPin = creditCardDetails.CreditCardPin
                    };
                    allcreditCardCredentials.Add(entityModelObject);
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
