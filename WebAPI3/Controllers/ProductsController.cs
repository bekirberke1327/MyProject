using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI3.Controllers
{
    [Route("api/[products]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public string Get()
        {
            return "Merhaba";
        }
    }
}
