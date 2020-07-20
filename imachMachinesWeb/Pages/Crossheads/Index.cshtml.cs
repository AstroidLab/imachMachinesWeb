using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.Crossheads
{
    public class IndexModel : PageModel
    {
        //private readonly ICrosshead crosshead;
        private readonly MockCrosshead crosshead;

        public IEnumerable<Crosshead> Crossheads { get; set; }

        //public IndexModel(ICrosshead crossheadRepository)
        public IndexModel(MockCrosshead crossheadRepository)
        {
            this.crosshead = crossheadRepository;
        }


        public void OnGet()
        {
            Crossheads = crosshead.GetAllCrossheads();
        }
    }
}