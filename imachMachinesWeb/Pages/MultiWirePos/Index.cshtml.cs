using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.MultiWirePos
{
    public class IndexModel : PageModel
    {
        //private readonly IMultiWirePo multiWirePo;
        private readonly MockMultiWirePo multiWirePo;

        public IEnumerable<MultiWirePo> MultiWirePos { get; set; }

        //public IndexModel(IMultiWirePo multiWirePoRepository)
        public IndexModel(MockMultiWirePo multiWirePoRepository)
        {
            this.multiWirePo = multiWirePoRepository;
        }


        public void OnGet()
        {
            MultiWirePos = multiWirePo.GetAllMultiWirePos();
        }
    }
}