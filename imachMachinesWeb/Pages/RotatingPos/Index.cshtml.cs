using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.RotatingPos
{
    public class IndexModel : PageModel
    {
        //private readonly IRotatingPo rotatingPo;
        private readonly MockRotatingPo rotatingPo;

        public IEnumerable<RotatingPo> RotatingPos { get; set; }

        //public IndexModel(IRotatingPo rotatingPoRepository)
        public IndexModel(MockRotatingPo rotatingPoRepository)
        {
            this.rotatingPo = rotatingPoRepository;
        }


        public void OnGet()
        {
            RotatingPos = rotatingPo.GetAllRotatingPos();
        }
    }
}