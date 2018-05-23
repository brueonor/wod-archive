using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using wod_archive.Models;

namespace wod_archive.Controllers
{
    [RoutePrefix("api/athletes")]
    public class AthletesController : ApiController
    {

        Athlete[] athletes = new Athlete[]
        {
            new Athlete{ Id = new Guid("ecafe31c-ae61-427c-8b9c-f52a35d3277b"), Nom = "Derp", Prenom = "Herp" },
            new Athlete{ Id = new Guid("02f1a615-cea8-4fc9-9b89-7eb9d3e2e231"), Nom = "Deag", Prenom = "Juan" }
        };

        Wod[] wods = new Wod[]
       {
            new Wod{Id = new Guid("42d8b82b-b609-4d53-8803-ec61f35fc06f"), Titre = "Murph", Description="blabla"},
            new Wod{Id = new Guid("f7a79432-2e41-4e44-ab7a-c1870be2dabe"), Titre = "Fran", Description="faeafsdf"},
            new Wod{Id = new Guid("7a3f7c61-127e-4f02-a5d2-02ec773680dc"), Titre = "Grace", Description="23rwsedfasd"},
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

        [Route("{athleteId}/wods")]
        [HttpGet]
        public IHttpActionResult GetAthleteWods(Guid athleteId)
        {
            return Ok(wods);
        }
    }
}
