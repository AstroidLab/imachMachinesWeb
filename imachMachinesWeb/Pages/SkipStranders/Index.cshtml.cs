using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imachMachinesWeb.Models;
using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imachMachinesWeb.Pages.SkipStranders
{
    public class IndexModel : PageModel
    {
        //private readonly ISkipStrander skipStrander;
        private readonly MockSkipStrander skipStrander;

        public IEnumerable<SkipStrander> SkipStranders { get; set; }

        //public IndexModel(ISkipStrander skipStranderRepository)
        public IndexModel(MockSkipStrander skipStranderRepository)
        {
            this.skipStrander = skipStranderRepository;
        }


        public void OnGet()
        {
            SkipStranders = skipStrander.GetAllSkipStranders();
        }
    }
}