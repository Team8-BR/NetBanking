using Microsoft.EntityFrameworkCore;
using Server.BusinessModels;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.DataAccessLayer
{
    public class NetBankingCredentialDao
    {
        public bool InsertNetBankingDetails(NetBankingCredential netBankingCredential)
        {
            int result = 0;
            try
            {
                using(var db= new BankingContext())
                {
                    DbSet<NetBankingCredentials>allNetBankingCredentials = db.NetBankingCredentials;
                    NetBankingCredentials entityModelObject = new NetBankingCredentials
                    {
                        UserId = netBankingCredential.UserId,
                        AccountNumber = netBankingCredential.AccountNumber,
                        NetBankingPassword = netBankingCredential.NetBankingPassword,
                        TransactionPassword = netBankingCredential.TransactionPassword
                    };
                    allNetBankingCredentials.Add(entityModelObject);
                    result = db.SaveChanges();

                }
                return result >0 ;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
