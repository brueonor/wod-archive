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
            new Wod{Id = Guid.NewGuid(), Titre = "Murph", Description="blabla"},
            new Wod{Id = Guid.NewGuid(), Titre = "Fran", Description="faeafsdf"},
            new Wod{Id = Guid.NewGuid(), Titre = "Grace", Description="23rwsedfasd"},
        };

        public IEnumerable<Wod> GetAllWods()
        {
            return wods;
        }

        public IHttpActionResult GetWod(Guid id)
        {
            var wod = wods.FirstOrDefault(x => x.Id == id);

            if (wod == null)
                return NotFound();

            return Ok(wod);
        }

    }
}
