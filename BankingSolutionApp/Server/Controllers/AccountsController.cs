using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.BusinessModels;
using Server.DataAccessLayer;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountFieldDao _accountFieldDao;

        public AccountsController(IAccountFieldDao accountFieldDao)
        {
            _accountFieldDao = accountFieldDao;
        }

        [HttpGet]
        public IActionResult GetAllAccountDetails()
        {
            AccountFieldDao accountFieldDao = new AccountFieldDao();
            var fetchedData = accountFieldDao.FetchAllAccount();
            return this.Ok(fetchedData);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FetchAccountById(int id)
        {
            AccountFieldDao accountFieldDao = new AccountFieldDao();
            var fetchedData = accountFieldDao.FetchAccountById(id);
            return this.Ok(fetchedData);
        }

        [HttpPost]
        public IActionResult AddProduct(AccountField account)
        {
            AccountFieldDao accountFieldDao = new AccountFieldDao();
            var result = accountFieldDao.InsertAccountField(account);
            return this.CreatedAtAction(
                "AddProduct",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = account
                }
                );
        }
    }
}
