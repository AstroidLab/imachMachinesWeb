using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.RigidArmorings
{
    public class IndexModel : PageModel
    {
        //private readonly IRigidArmoring rigidArmoring;
        private readonly MockRigidArmoring rigidArmoring;

        public IEnumerable<RigidArmoring> RigidArmorings { get; set; }

        //public IndexModel(IRigidArmoring rigidArmoringRepository)
        public IndexModel(MockRigidArmoring rigidArmoringRepository)
        {
            this.rigidArmoring = rigidArmoringRepository;
        }


        public void OnGet()
        {
            RigidArmorings = rigidArmoring.GetAllRigidArmorings();
        }
    }
}