using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SpoolerTus
{
    public class IndexModel : PageModel
    {
        //private readonly ISpoolerTu spoolerTu;
        private readonly MockSpoolerTu spoolerTu;

        public IEnumerable<SpoolerTu> SpoolerTus { get; set; }

        //public IndexModel(ISpoolerTu spoolerTuRepository)
        public IndexModel(MockSpoolerTu spoolerTuRepository)
        {
            this.spoolerTu = spoolerTuRepository;
        }


        public void OnGet()
        {
            SpoolerTus = spoolerTu.GetAllSpoolerTus();
        }
    }
}