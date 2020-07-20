using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.DiscCapstans
{
    public class IndexModel : PageModel
    {
        //private readonly IDiscCapstan discCapstan;
        private readonly MockDiscCapstan discCapstan;

        public IEnumerable<DiscCapstan> DiscCapstans { get; set; }

        //public IndexModel(IDiscCapstan discCapstanRepository)
        public IndexModel(MockDiscCapstan discCapstanRepository)
        {
            this.discCapstan = discCapstanRepository;
        }


        public void OnGet()
        {
            DiscCapstans = discCapstan.GetAllDiscCapstans();

        }
    }
}