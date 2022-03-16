using server.EntityModels;
using System;

namespace server.Data_Access_Layer
{
    public class AccountfieldDao
    {

        public bool AddAccountDetail(AccountFields accountFields )
        {
            bool status = false;

            try
            {
                using(var db = new BankingContext())
                {
                    db.AccountFields.Add( accountFields );
                    status = true;
                }
            }
            catch( Exception ex)
            {
                throw ex;
            }

            return status;
        }
    }
}
