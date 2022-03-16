using Microsoft.EntityFrameworkCore;
using Server.BusinessModels;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.DataAccessLayer
{
    public class DebitCardCredentialDao
    {
        public bool InsertDebitCardDetails(DebitCardCredential debitCardCredential)
        {
            int result = 0;
            try
            {
                using (var db = new BankingContext())
                {
                    DbSet<DebitCardCredentials> allDebitCardCredentials = db.DebitCardCredentials;
                    DebitCardCredentials entityModelObject = new DebitCardCredentials
                    {
                        DebitCardNumber = debitCardCredential.DebitCardNumber,
                        DebitCardExpiry = debitCardCredential.DebitCardExpiry,
                        DebitCardCvv = debitCardCredential.DebitCardCvv,
                        DebitCardPin = debitCardCredential.DebitCardPin
                    };
                    allDebitCardCredentials.Add(entityModelObject);
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
