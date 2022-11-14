using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Agencia.Controllers
{
    [Route("api/controller]")]
    [ApiController]

    public class HomeController1 : Controller
    {
        [HttpGet]
        public ActionResult<List<DestinoModel>> BuscarDestino()
        {
        
           

            return Ok();
        }
    }

    public class DestinoModel
    {
    }
}
}
