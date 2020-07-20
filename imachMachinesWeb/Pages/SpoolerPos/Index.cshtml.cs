using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SpoolerPos
{
    public class IndexModel : PageModel
    {
        //private readonly ISpoolerPo spoolerPo;
        private readonly MockSpoolerPo spoolerPo;

        public IEnumerable<SpoolerPo> SpoolerPos { get; set; }

        //public IndexModel(ISpoolerPo spoolerPoRepository)
        public IndexModel(MockSpoolerPo spoolerPoRepository)
        {
            this.spoolerPo = spoolerPoRepository;
        }


        public void OnGet()
        {
            SpoolerPos = spoolerPo.GetAllSpoolerPos();
        }
    }
}