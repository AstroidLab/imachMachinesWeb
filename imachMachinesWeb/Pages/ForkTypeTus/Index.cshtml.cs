using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.ForkTypeTus
{
    public class IndexModel : PageModel
    {
        //private readonly IForkTypeTu forkTypeTu;
        private readonly MockForkTypeTu forkTypeTu;

        public IEnumerable<ForkTypeTu> ForkTypeTus { get; set; }

        //public IndexModel(IForkTypeTu forkTypeTuRepository)
        public IndexModel(MockForkTypeTu forkTypeTuRepository)
        {
            this.forkTypeTu = forkTypeTuRepository;
        }


        public void OnGet()
        {
            ForkTypeTus = forkTypeTu.GetAllForkTypeTus();
        }
    }
}