using System;
using Microsoft.EntityFrameworkCore;
using server.EntityModels;

public class NetBankingCredentialDao
{
    public NetBankingCredentialDao()
    {
    }
    public bool InsertNetBankingDetails(NetBankingCredentials netBankingCredentials)
    {
        int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                DbSet<NetBankingCredentials> allNetBankingDetails = db.NetBankingCredentials;
                NetBankingCredentials entityModelObject = new NetBankingCredentials
                {
                  UserId = netBankingCredentials.UserId,

                  NetBankingPassword = netBankingCredentials.NetBankingPassword,

                  TransactionPassword = netBankingCredentials.TransactionPassword,

                  AccountNumber = netBankingCredentials.AccountNumber
                };
                allNetBankingDetails.Add(entityModelObject);
                result = db.SaveChanges();
            }
            return result > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }   
    public bool UpdateNetBankingDetails(NetBankingCredentials netBankingUpdateCredentials)
    {
        int result = 0;
        try
        {
            using(var db = new BankingContext())
            {
                DbSet<NetBankingCredentials>allNetBankingUpdateCredentials = db.NetBankingCredentials;
                NetBankingCredentials entityModelObject = new NetBankingCredentials
                {
                    UserId = netBankingUpdateCredentials.UserId,

                    NetBankingPassword = netBankingUpdateCredentials.NetBankingPassword,

                    TransactionPassword = netBankingUpdateCredentials.TransactionPassword,

                    AccountNumber = netBankingUpdateCredentials.AccountNumber
                };
                allNetBankingUpdateCredentials.Add(entityModelObject);
                result=db.SaveChanges();
            }
            return result > 0;
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

}
