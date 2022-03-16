using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Data_Access_Layer;
using server.EntityModels;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        [Route("{AccountField}")]
        public IActionResult InsertAccountData(AccountFields accountFields )
        {
            AccountfieldDao data = new AccountfieldDao();
            data.AddAccountDetail(accountFields);
            return this.Ok(200);
        }


    }
}
