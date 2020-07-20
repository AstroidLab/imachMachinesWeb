using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.LengthMeasures
{
    public class IndexModel : PageModel
    {
        //private readonly ILengthMeasure lengthMeasure;
        private readonly MockLengthMeasure lengthMeasure;

        public IEnumerable<LengthMeasure> LengthMeasures { get; set; }

        //public IndexModel(ILengthMeasure lengthMeasureRepository)
        public IndexModel(MockLengthMeasure lengthMeasureRepository)
        {
            this.lengthMeasure = lengthMeasureRepository;
        }


        public void OnGet()
        {
            LengthMeasures = lengthMeasure.GetAllLengthMeasures();
        }
    }
}