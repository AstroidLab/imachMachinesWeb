using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SemiAutomaticCoilers
{
    public class IndexModel : PageModel
    {
        //private readonly ISemiAutomaticCoiler semiAutomaticCoiler;
        private readonly MockSemiAutomaticCoiler semiAutomaticCoiler;

        public IEnumerable<SemiAutomaticCoiler> SemiAutomaticCoilers { get; set; }

        //public IndexModel(ISemiAutomaticCoiler semiAutomaticCoilerRepository)
        public IndexModel(MockSemiAutomaticCoiler semiAutomaticCoilerRepository)
        {
            this.semiAutomaticCoiler = semiAutomaticCoilerRepository;
        }


        public void OnGet()
        {
            SemiAutomaticCoilers = semiAutomaticCoiler.GetAllSemiAutomaticCoilers();
        }
    }
}