using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.TapingHeads
{
    public class IndexModel : PageModel
    {
        //private readonly ITapingHead tapingHead;
        private readonly MockTapingHead tapingHead;

        public IEnumerable<TapingHead> TapingHeads { get; set; }

        //public IndexModel(ITapingHead tapingHeadRepository)
        public IndexModel(MockTapingHead tapingHeadRepository)
        {
            this.tapingHead = tapingHeadRepository;
        }


        public void OnGet()
        {
            TapingHeads = tapingHead.GetAllTapingHeads();
        }
    }
}