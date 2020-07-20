using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.DoubleTwistBunchers
{
    public class IndexModel : PageModel
    {
        //private readonly IDoubleTwistBuncher doubleTwistBuncher;
        private readonly MockDoubleTwistBuncher doubleTwistBuncher;

        public IEnumerable<DoubleTwistBuncher> DoubleTwistBunchers { get; set; }

        //public IndexModel(IDoubleTwistBuncher doubleTwistBuncherRepository)
        public IndexModel(MockDoubleTwistBuncher doubleTwistBuncherRepository)
        {
            this.doubleTwistBuncher = doubleTwistBuncherRepository;
        }


        public void OnGet()
        {
            DoubleTwistBunchers = doubleTwistBuncher.GetAllDoubleTwistBunchers();
        }
    }
}