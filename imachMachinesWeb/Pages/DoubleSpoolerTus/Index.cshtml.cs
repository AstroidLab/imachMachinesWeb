using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.DoubleSpoolerTus
{
    public class IndexModel : PageModel
    {
        //private readonly IDoubleSpoolerTu doubleSpoolerTu;
        private readonly MockDoubleSpoolerTu doubleSpoolerTu;

        public IEnumerable<DoubleSpoolerTu> DoubleSpoolerTus { get; set; }

        //public IndexModel(IDoubleSpoolerTu doubleSpoolerTuRepository)
        public IndexModel(MockDoubleSpoolerTu doubleSpoolerTuRepository)
        {
            this.doubleSpoolerTu = doubleSpoolerTuRepository;
        }


        public void OnGet()
        {
            DoubleSpoolerTus = doubleSpoolerTu.GetAllDoubleSpoolerTus();
        }
    }
}