using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wod_archive.Models
{
    internal static class WodExtension
    {
        public static Wod ToModel(this WodServices.Business.Wod wod)
        {
            return new Wod
            {
                Id = wod.Id,
                Description = wod.Description,
                Titre = wod.Titre
            };
        }
    }
}