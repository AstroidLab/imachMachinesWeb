using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.PairingPos
{
    public class IndexModel : PageModel
    {
        //private readonly IPairingPo pairingPo;
        private readonly MockPairingPo pairingPo;

        public IEnumerable<PairingPo> PairingPos { get; set; }

        //public IndexModel(IPairingPo pairingPoRepository)
        public IndexModel(MockPairingPo pairingPoRepository)
        {
            this.pairingPo = pairingPoRepository;
        }


        public void OnGet()
        {
            PairingPos = pairingPo.GetAllPairingPos();
        }
    }
}