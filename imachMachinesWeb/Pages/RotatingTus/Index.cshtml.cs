using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.RotatingTus
{
    public class IndexModel : PageModel
    {
        //private readonly IRotatingTu rotatingTu;
        private readonly MockRotatingTu rotatingTu;

        public IEnumerable<RotatingTu> RotatingTus { get; set; }

        //public IndexModel(IRotatingTu rotatingTuRepository)
        public IndexModel(MockRotatingTu rotatingTuRepository)
        {
            this.rotatingTu = rotatingTuRepository;
        }


        public void OnGet()
        {
            RotatingTus = rotatingTu.GetAllRotatingTus();
        }
    }
}