using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.PortalTypeTus
{
    public class IndexModel : PageModel
    {
        //private readonly IPortalTypeTu portalTypeTu;
        private readonly MockPortalTypeTu portalTypeTu;

        public IEnumerable<PortalTypeTu> PortalTypeTus { get; set; }

        //public IndexModel(IPortalTypeTu portalTypeTuRepository)
        public IndexModel(MockPortalTypeTu portalTypeTuRepository)
        {
            this.portalTypeTu = portalTypeTuRepository;
        }


        public void OnGet()
        {
            PortalTypeTus = portalTypeTu.GetAllPortalTypeTus();
        }
    }
}