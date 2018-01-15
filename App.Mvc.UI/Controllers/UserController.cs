using App.Mvc.IServices;
using App.Mvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace App.Mvc.UI.Controllers
{
    public class UserController : Controller
    {
        IUserInfomationServices userService;
        public UserController(IUserInfomationServices userService)
        {
            this.userService = userService;
        }
        // GET: Admin/UserInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            try
            {
                int pageIndex = int.Parse(Request["page"]);
                int pageSize = int.Parse(Request["limit"]);
                string username = Request["UserName"];

                Expression<Func<UserInfomation, bool>> predicate = null;
                if (!string.IsNullOrEmpty(username))
                {
                    predicate = f => f.User_Name.Contains(username);
                }
                else
                {
                    predicate = f => true;
                }
                int total = 0;
                var userInfo = userService.QueryByPage(pageIndex, pageSize, out total, predicate, r => r.Create_Time, false);

                var result = new
                {
                    code = 0,
                    msg = "",
                    count = total,
                    data = userInfo
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Content("错误提示：" + ex.Message);
            }
        }
    }
}