using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using wod_archive.Models;
using WodServices.Services;

namespace wod_archive.Controllers
{
    public class WodsController : ApiController
    {
        private IWodService _wodService;

        public WodsController(IWodService wodService)
        {
            _wodService = wodService;
        }

        [HttpGet]
        public IEnumerable<Wod> GetAllWods()
        {
            return _wodService.GetWods().Select(x => x.ToModel());
        }

        [HttpGet]
        public IHttpActionResult GetWod(Guid id)
        {
            var wod = GetAllWods().FirstOrDefault(x => x.Id == id);

            if (wod == null)
                return NotFound();

            return Ok(wod);
        }

    }
}
