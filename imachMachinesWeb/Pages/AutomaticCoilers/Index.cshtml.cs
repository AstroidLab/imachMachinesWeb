using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.AutomaticCoilers
{
    public class IndexModel : PageModel
    {
        //private readonly IAutomaticCoiler automaticCoiler;
        private readonly MockAutomaticCoiler automaticCoiler;

        public IEnumerable<AutomaticCoiler> AutomaticCoilers { get; set; }

        //public IndexModel(IAutomaticCoiler automaticCoilerRepository)
        public IndexModel(MockAutomaticCoiler automaticCoilerRepository)
        {
            this.automaticCoiler = automaticCoilerRepository;
        }


        public void OnGet()
        {
            AutomaticCoilers = automaticCoiler.GetAllAutomaticCoilers();
        }
    }
}