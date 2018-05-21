using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using wod_archive.Models;

namespace wod_archive.Controllers
{
    public class WodsController : ApiController
    {
       
        Wod[] wods = new Wod[]
        {
            new Wod{Id = new Guid("42d8b82b-b609-4d53-8803-ec61f35fc06f"), Titre = "Murph", Description="blabla"},
            new Wod{Id = new Guid("f7a79432-2e41-4e44-ab7a-c1870be2dabe"), Titre = "Fran", Description="faeafsdf"},
            new Wod{Id = new Guid("7a3f7c61-127e-4f02-a5d2-02ec773680dc"), Titre = "Grace", Description="23rwsedfasd"},
        };

        [HttpGet]
        public IEnumerable<Wod> GetAllWods()
        {
            return wods;
        }

        [HttpGet]
        public IHttpActionResult GetWod(Guid id)
        {
            var wod = wods.FirstOrDefault(x => x.Id == id);

            if (wod == null)
                return NotFound();

            return Ok(wod);
        }

    }
}
