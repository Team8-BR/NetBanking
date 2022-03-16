using System;
using Microsoft.EntityFrameworkCore;
using server.EntityModels;

public class CreditCardCredentialsDao
{
	public CreditCardCredentialsDao()
	{
	}
	public bool InsertCreditCardDetails(CreditCardCredentials creditCardCredentials)
    {
		int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                DbSet<CreditCardCredentials> allCreditCardDetails = db.CreditCardCredentials;
                CreditCardCredentials entityModelObject = new CreditCardCredentials
                {
                    CreditCardNumber = creditCardCredentials.CreditCardNumber,
                    CreditCardExpiry = creditCardCredentials.CreditCardExpiry,
                    CreditCardCvv = creditCardCredentials.CreditCardCvv
                };
                allCreditCardDetails.Add(entityModelObject);
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
