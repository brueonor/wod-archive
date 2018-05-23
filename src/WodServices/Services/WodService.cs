using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodServices.Business;

namespace WodServices.Services
{
    public class WodService : IWodService
    {

        private Wod[] wods = new Wod[]
       {
            new Wod{Id = new Guid("42d8b82b-b609-4d53-8803-ec61f35fc06f"), Titre = "Murph", Description="blabla"},
            new Wod{Id = new Guid("f7a79432-2e41-4e44-ab7a-c1870be2dabe"), Titre = "Fran", Description="faeafsdf"},
            new Wod{Id = new Guid("7a3f7c61-127e-4f02-a5d2-02ec773680dc"), Titre = "Grace", Description="23rwsedfasd"},
       };

        public IEnumerable<Wod> GetWods()
        {
            return wods;
        }
    }

    public interface IWodService
    {
        IEnumerable<Wod> GetWods();
    }
}
