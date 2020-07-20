using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SingleTwistBunchers
{
    public class IndexModel : PageModel
    {
        //private readonly ISingleTwistBuncher singleTwistBuncher;
        private readonly MockSingleTwistBuncher singleTwistBuncher;

        public IEnumerable<SingleTwistBuncher> SingleTwistBunchers { get; set; }

        //public IndexModel(ISingleTwistBuncher singleTwistBuncherRepository)
        public IndexModel(MockSingleTwistBuncher singleTwistBuncherRepository)
        {
            this.singleTwistBuncher = singleTwistBuncherRepository;
        }


        public void OnGet()
        {
            SingleTwistBunchers = singleTwistBuncher.GetAllSingleTwistBunchers();
        }
    }
}