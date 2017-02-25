using System;
using System.Threading.Tasks;
using System.Web.Http;
using HostelSystem.Service.Service;
using HostelSystem.Web.Api.Utility;

namespace HostelSystem.Web.Api.Controllers
{
    public class RezerwacjaController : ApiController
    {
        private readonly IRezerwacjaService _service;

        public RezerwacjaController(IRezerwacjaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet]
        [ValidateIdFormat]
        public async Task<IHttpActionResult> Get(Guid id)
        {
            return Ok(await _service.Get(id));
        }
    }
}