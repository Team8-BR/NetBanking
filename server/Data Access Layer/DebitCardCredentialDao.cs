using System;
using Microsoft.EntityFrameworkCore;
using server.EntityModels;

public class DebitCardCredentialsDao
{
    public DebitCardCredentialsDao()
    {
    }
    public bool InsertDebitCardDetails(DebitCardCredentials debitCardCredentials)
    {
        int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                DbSet<DebitCardCredentials> allDebitCardDetails = db.DebitCardCredentials;
                DebitCardCredentials entityModelObject = new DebitCardCredentials
                {
                    DebitCardNumber = debitCardCredentials.DebitCardNumber,
                    DebitCardExpiry = debitCardCredentials.DebitCardExpiry,
                    DebitCardCvv = debitCardCredentials.DebitCardCvv
                };
                allDebitCardDetails.Add(entityModelObject);
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

