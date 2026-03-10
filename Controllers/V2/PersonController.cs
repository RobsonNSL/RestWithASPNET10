using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Service;

namespace RestWithASPNET10.Controllers.V2
{
    [Route("api/[controller]/v2")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }
    }
}
