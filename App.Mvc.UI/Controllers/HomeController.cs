using App.Mvc.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Mvc.UI.Controllers
{
    public class HomeController : Controller
    {
        IMenuServices menuService;
        public HomeController(IMenuServices menuService)
        {
            this.menuService = menuService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuItem()
        {
            #region 得到菜单
            
            var menuList = menuService.QueryWhere(m=>m.Menu_ID>0);

            #endregion
            return PartialView(menuList);
        }
    }
}