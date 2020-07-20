using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.ForkTypePos
{
    public class IndexModel : PageModel
    {
        //private readonly IForkTypePo forkTypePo;
        private readonly MockForkTypePo forkTypePo;

        public IEnumerable<ForkTypePo> ForkTypePos { get; set; }

        //public IndexModel(IForkTypePo forkTypePoRepository)
        public IndexModel(MockForkTypePo forkTypePoRepository)
        {
            this.forkTypePo = forkTypePoRepository;
        }


        public void OnGet()
        {
            ForkTypePos = forkTypePo.GetAllForkTypePos();
        }
    }
}