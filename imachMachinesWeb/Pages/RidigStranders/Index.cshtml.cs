using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.RigidStranders
{
    public class IndexModel : PageModel
    {
        //private readonly IRigidStrander rigidStrander;
        private readonly MockRigidStrander rigidStrander;

        public IEnumerable<RigidStrander> RigidStranders { get; set; }

        //public IndexModel(IRigidStrander rigidStranderRepository)
        public IndexModel(MockRigidStrander rigidStranderRepository)
        {
            this.rigidStrander = rigidStranderRepository;
        }


        public void OnGet()
        {
            RigidStranders = rigidStrander.GetAllRigidStranders();
        }
    }
}