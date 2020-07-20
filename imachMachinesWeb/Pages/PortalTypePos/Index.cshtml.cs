using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.PortalTypePos
{
    public class IndexModel : PageModel
    {
        //private readonly IPortalTypePo portalTypePo;
        private readonly MockPortalTypePo portalTypePo;

        public IEnumerable<PortalTypePo> PortalTypePos { get; set; }

        //public IndexModel(IPortalTypePo portalTypePoRepository)
        public IndexModel(MockPortalTypePo portalTypePoRepository)
        {
            this.portalTypePo = portalTypePoRepository;
        }


        public void OnGet()
        {
            PortalTypePos = portalTypePo.GetAllPortalTypePos();
        }
    }
}