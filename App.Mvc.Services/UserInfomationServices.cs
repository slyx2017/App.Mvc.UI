using App.Mvc.IRepository;
using App.Mvc.IServices;
using App.Mvc.Model.Models;
using App.Mvc.Services.Base;

namespace App.Mvc.Services
{
    public partial class UserInfomationServices:BaseServices<UserInfomation>,IUserInfomationServices
    {
        //IUserInfomationRepository dal;
        //public UserInfomationServices(IUserInfomationRepository dal)
        //{
        //    this.dal = dal;
        //    base.baseDal = dal;
        //}
    }
}
