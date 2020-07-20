using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.RotatingCaterpillarCapstans
{
    public class IndexModel : PageModel
    {
        //private readonly IRotatingCaterpillarCapstan rotatingCaterpillarCapstan;
        private readonly MockRotatingCaterpillarCapstan rotatingCaterpillarCapstan;

        public IEnumerable<RotatingCaterpillarCapstan> RotatingCaterpillarCapstans { get; set; }

        //public IndexModel(IRotatingCaterpillarCapstan rotatingCaterpillarCapstanRepository)
        public IndexModel(MockRotatingCaterpillarCapstan rotatingCaterpillarCapstanRepository)
        {
            this.rotatingCaterpillarCapstan = rotatingCaterpillarCapstanRepository;
        }


        public void OnGet()
        {
            RotatingCaterpillarCapstans = rotatingCaterpillarCapstan.GetAllRotatingCaterpillarCapstans();
        }
    }
}