using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.PowderingDevices
{
    public class IndexModel : PageModel
    {
        //private readonly IPowderingDevice powderingDevice;
        private readonly MockPowderingDevice powderingDevice;

        public IEnumerable<PowderingDevice> PowderingDevices { get; set; }

        //public IndexModel(IPowderingDevice powderingDeviceRepository)
        public IndexModel(MockPowderingDevice powderingDeviceRepository)
        {
            this.powderingDevice = powderingDeviceRepository;
        }


        public void OnGet()
        {
            PowderingDevices = powderingDevice.GetAllPowderingDevices();
        }
    }
}