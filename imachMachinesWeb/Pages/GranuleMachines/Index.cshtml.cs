using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.GranuleMachines
{
    public class IndexModel : PageModel
    {
        //private readonly IGranuleMachine granuleMachine;
        private readonly MockGranuleMachine granuleMachine;

        public IEnumerable<GranuleMachine> GranuleMachines { get; set; }

        //public IndexModel(IGranuleMachine granuleMachineRepository)
        public IndexModel(MockGranuleMachine granuleMachineRepository)
        {
            this.granuleMachine = granuleMachineRepository;
        }


        public void OnGet()
        {
            GranuleMachines = granuleMachine.GetAllGranuleMachines();
        }
    }
}