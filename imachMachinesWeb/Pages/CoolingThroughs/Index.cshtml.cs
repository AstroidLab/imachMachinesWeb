using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.CoolingThroughs
{
    public class IndexModel : PageModel
    {
        //private readonly ICoolingThrough coolingThrough;
        private readonly MockCoolingThrough coolingThrough;

        public IEnumerable<CoolingThrough> CoolingThroughs { get; set; }

        //public IndexModel(ICoolingThrough coolingThroughRepository)
        public IndexModel(MockCoolingThrough coolingThroughRepository)
        {
            this.coolingThrough = coolingThroughRepository;
        }


        public void OnGet()
        {
            CoolingThroughs = coolingThrough.GetAllCoolingThroughs();
        }
    }
}