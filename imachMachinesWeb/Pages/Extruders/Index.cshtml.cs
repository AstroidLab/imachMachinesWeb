using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.Extruders
{
    public class IndexModel : PageModel
    {
        //private readonly IExtruder extruder;
        private readonly MockExtruder extruder;

        public IEnumerable<Extruder> Extruders { get; set; }

        //public IndexModel(IExtruder extruderRepository)
        public IndexModel(MockExtruder extruderRepository)
        {
            this.extruder = extruderRepository;
        }


        public void OnGet()
        {
            Extruders = extruder.GetAllExtruders();
        }
    }
}