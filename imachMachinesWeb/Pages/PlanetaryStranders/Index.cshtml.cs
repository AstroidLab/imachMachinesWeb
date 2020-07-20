using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.PlanetaryStranders
{
    public class IndexModel : PageModel
    {
        //private readonly IPlanetaryStrander planetaryStrander;
        private readonly MockPlanetaryStrander planetaryStrander;

        public IEnumerable<PlanetaryStrander> PlanetaryStranders { get; set; }

        //public IndexModel(IPlanetaryStrander planetaryStranderRepository)
        public IndexModel(MockPlanetaryStrander planetaryStranderRepository)
        {
            this.planetaryStrander = planetaryStranderRepository;
        }


        public void OnGet()
        {
            PlanetaryStranders = planetaryStrander.GetAllPlanetaryStranders();
        }
    }
}