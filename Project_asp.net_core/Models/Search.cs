using Microsoft.AspNetCore.Mvc;
using Project_asp.net_core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_asp.net_core.Models
{
    public class Search: ViewComponent
    {
        private readonly Project_aspnet_coreContext _context;

        public Search(Project_aspnet_coreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index", _context.Category.ToList());
        }
    }
}
