using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using wod_archive.Models;

namespace wod_archive.Controllers
{
    public class AthletesController : ApiController
    {

        Athlete[] athletes = new Athlete[]
        {
            new Athlete{ Id = new Guid("ecafe31c-ae61-427c-8b9c-f52a35d3277b"), Nom = "Derp", Prenom = "Herp" },
            new Athlete{ Id = new Guid("02f1a615-cea8-4fc9-9b89-7eb9d3e2e231"), Nom = "Deag", Prenom = "Juan" }
        };

        [HttpGet]
        public IEnumerable<Athlete> GetAthletes()
        {
            return athletes;
        }

        [HttpGet]
        public IHttpActionResult GetAthlete(Guid id)
        {
            var athlete = athletes.FirstOrDefault(x => x.Id == id);

            if (athlete == null)
                return NotFound();

            return Ok(athlete);
        }
    }
}
