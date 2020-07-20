using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.CompactingHeads
{
    public class IndexModel : PageModel
    {
        //private readonly ICompactingHead compactingHead;
        private readonly MockCompactingHead compactingHead;

        public IEnumerable<CompactingHead> CompactingHeads { get; set; }

        //public IndexModel(ICompactingHead compactingHeadRepository)
        public IndexModel(MockCompactingHead compactingHeadRepository)
        {
            this.compactingHead = compactingHeadRepository;
        }


        public void OnGet()
        {
            CompactingHeads = compactingHead.GetAllCompactingHeads();
        }
    }
}