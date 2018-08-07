using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsViewer.Data;
using HotelsViewer.Services;
using Microsoft.AspNetCore.Mvc;


namespace HotelsViewer.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
