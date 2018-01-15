using App.Mvc.IRepository;
using App.Mvc.Model.Models;
using App.Mvc.Repository.Base;

namespace App.Mvc.Repository
{
    public partial class UserInfomationRepository: BaseRepository<UserInfomation>,IUserInfomationRepository
    {
    }
}
