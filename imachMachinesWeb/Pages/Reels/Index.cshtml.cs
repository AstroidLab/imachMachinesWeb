using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.Reels
{
    public class IndexModel : PageModel
    {
        //private readonly IReel reel;
        private readonly MockReel reel;

        public IEnumerable<Reel> Reels { get; set; }

        //public IndexModel(IReel reelRepository)
        public IndexModel(MockReel reelRepository)
        {
            this.reel = reelRepository;
        }


        public void OnGet()
        {
            Reels = reel.GetAllReels();
        }
    }
}