using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.TapePos
{
    public class IndexModel : PageModel
    {
        //private readonly ITapePo tapePo;
        private readonly MockTapePo tapePo;

        public IEnumerable<TapePo> TapePos { get; set; }

        //public IndexModel(ITapePo tapePoRepository)
        public IndexModel(MockTapePo tapePoRepository)
        {
            this.tapePo = tapePoRepository;
        }


        public void OnGet()
        {
            TapePos = tapePo.GetAllTapePos();
        }
    }
}