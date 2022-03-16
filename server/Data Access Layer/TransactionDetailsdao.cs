using System;
using Microsoft.EntityFrameworkCore;
using server.EntityModels;
{
    public class TransactionDetailsDao
    {
    
    public bool InsertTransactionDetails(TransactionDetails transactionDetails)
    {
        int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                DbSet<TransactionDetails>allTransactionDtails = db.TransactionDetails;
                TransactionDetails entityModelObject = new TransactionDetails
                {
                    RecipientAccountNumber= transactionDetails.RecipientAccountNumber,
                    Name= transactionDetails.Name,
                    Nikename= transactionDetails.Nikename,
                    Transactionamount= transactionDetails.Transactionamount,
                    TransactionDate= transactionDetails.TransactionDate,
                    ModId= transactionDetails.ModId,
                    Remark= transactionDetails.Remark,
                    AccountNumber= transactionDetails.AccountNumber,
                    TransactionReferenceId= transactionDetails.TransactionReferenceId,

                };
                allTransactionDetails.Add(entityModelObject);
                result = db.SaveChanges();
            }
            return result > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public bool UpdateTransactionDetails(UpdateTransactionDetails transactionUpdateDetails)
    {
        int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                Db<TransactionDetails> allTransactionDetails = db.TransactionDetails;
                TransactionDetails entityModelObject = new TransactionDetails
                {
                    RecipientAccountNumber=transactionUpdataDetails.RecipientAccountNumber,
                    Name=transactionUpdateDetails.Name,
                    Nickname=transactionUpdateDetails.Nickname,
                    Transactionamount=transactionUpdateDetails.Transactionamount,
                    TransactionDate=transactionUpdateDetails.TransactionDate,
                    ModeId= transactionUpdateDetails.ModeId,
                    Remark=transactionUpdateDetails.Remark,
                    AccountNumber=transactionUpdateDetails.AccountNumber,
                    TransactionReferenceId=transactionUpdateDetails.TransactionReferenceId,

                };
                allTransactionDetails.Add(entityModelObject);
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



   



