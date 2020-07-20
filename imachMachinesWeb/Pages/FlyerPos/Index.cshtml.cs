using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.FlyerPos
{
    public class IndexModel : PageModel
    {
        //private readonly IFlyerPo flyerPo;
        private readonly MockFlyerPo flyerPo;

        public IEnumerable<FlyerPo> FlyerPos { get; set; }

        //public IndexModel(IFlyerPo flyerPoRepository)
        public IndexModel(MockFlyerPo flyerPoRepository)
        {
            this.flyerPo = flyerPoRepository;
        }


        public void OnGet()
        {
            FlyerPos = flyerPo.GetAllFlyerPos();
        }
    }
}