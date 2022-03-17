using Server.BusinessModels;
using Server.Repository;
using System.Collections.Generic;

namespace Server.DataAccessLayer
{
    public interface IAccountFieldDao
    {
        bool AddAccountDetail(AccountFields account);
        AccountField FetchAccountById(int id);
        List<AccountField> FetchAllAccount();
        bool InsertAccountField(AccountField p);
    }
}