using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.Dancers
{
    public class IndexModel : PageModel
    {
        //private readonly IDancer dancer;
        private readonly MockDancer dancer;

        public IEnumerable<Dancer> Dancers { get; set; }

        //public IndexModel(IDancer dancerRepository)
        public IndexModel(MockDancer dancerRepository)
        {
            this.dancer = dancerRepository;
        }


        public void OnGet()
        {
            Dancers = dancer.GetAllDancers();
        }
    }
}