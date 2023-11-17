using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCailfornia.viewComponents
{   
    [ViewComponent]
    public class MonthlySpecialViewComponent: ViewComponent
    {
        public string Invoke()
        {
            return "TODO: Show monthly special";
        }
    }
}
