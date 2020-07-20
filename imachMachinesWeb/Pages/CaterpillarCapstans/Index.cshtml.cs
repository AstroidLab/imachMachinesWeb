using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.CaterpillarCapstans
{
    public class IndexModel : PageModel
    {
        //private readonly ICaterpillarCapstan caterpillarCapstan;
        private readonly MockCaterpillarCapstan caterpillarCapstan;

        public IEnumerable<CaterpillarCapstan> CaterpillarCapstans { get; set; }

        //public IndexModel(ICaterpillarCapstan caterpillarCapstanRepository)
        public IndexModel(MockCaterpillarCapstan caterpillarCapstanRepository)
        {
            this.caterpillarCapstan = caterpillarCapstanRepository;
        }


        public void OnGet()
        {
            CaterpillarCapstans = caterpillarCapstan.GetAllCaterpillarCapstans();
        }
    }
}