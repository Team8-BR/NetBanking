using Server.BusinessModels;
using Server.Repository;
using System;

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
    }
}
