using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SpareParts
{
    public class IndexModel : PageModel
    {
        //private readonly ISparePart sparePart;
        private readonly MockSparePart sparePart;

        public IEnumerable<SparePart> SpareParts { get; set; }

        //public IndexModel(ISparePart sparePartRepository)
        public IndexModel(MockSparePart sparePartRepository)
        {
            this.sparePart = sparePartRepository;
        }


        public void OnGet()
        {
            SpareParts = sparePart.GetAllSpareParts();
        }
    }
}