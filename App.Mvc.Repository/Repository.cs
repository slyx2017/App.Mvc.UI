
using App.Mvc.IRepository;
using App.Mvc.Model.Models;
using App.Mvc.Repository.Base;
namespace App.Mvc.Repository
{
        public partial class ActiveConditionRepository : BaseRepository<ActiveCondition>, IActiveConditionRepository
		{

		}
        public partial class ButtonRepository : BaseRepository<Button>, IButtonRepository
		{

		}
        public partial class DictionaryRepository : BaseRepository<Dictionary>, IDictionaryRepository
		{

		}
        public partial class DictionaryCategoryRepository : BaseRepository<DictionaryCategory>, IDictionaryCategoryRepository
		{

		}
        public partial class ElementInfoRepository : BaseRepository<ElementInfo>, IElementInfoRepository
		{

		}
        public partial class FlowActiveRepository : BaseRepository<FlowActive>, IFlowActiveRepository
		{

		}
        public partial class FlowApproveRepository : BaseRepository<FlowApprove>, IFlowApproveRepository
		{

		}
        public partial class FlowInfoRepository : BaseRepository<FlowInfo>, IFlowInfoRepository
		{

		}
        public partial class FlowStepRepository : BaseRepository<FlowStep>, IFlowStepRepository
		{

		}
        public partial class Form_ElementRepository : BaseRepository<Form_Element>, IForm_ElementRepository
		{

		}
        public partial class FormInfoRepository : BaseRepository<FormInfo>, IFormInfoRepository
		{

		}
        public partial class LeaveInfoRepository : BaseRepository<LeaveInfo>, ILeaveInfoRepository
		{

		}
        public partial class LoginLogRepository : BaseRepository<LoginLog>, ILoginLogRepository
		{

		}
        public partial class MenuRepository : BaseRepository<Menu>, IMenuRepository
		{

		}
        public partial class Menu_ButtonRepository : BaseRepository<Menu_Button>, IMenu_ButtonRepository
		{

		}
        public partial class MessageRepository : BaseRepository<Message>, IMessageRepository
		{

		}
        public partial class NewRepository : BaseRepository<New>, INewRepository
		{

		}
        public partial class RoleRepository : BaseRepository<Role>, IRoleRepository
		{

		}
        public partial class Role_ButtonRepository : BaseRepository<Role_Button>, IRole_ButtonRepository
		{

		}
        public partial class Role_MenuRepository : BaseRepository<Role_Menu>, IRole_MenuRepository
		{

		}
        public partial class SystemInfoRepository : BaseRepository<SystemInfo>, ISystemInfoRepository
		{

		}
        public partial class User_MessageRepository : BaseRepository<User_Message>, IUser_MessageRepository
		{

		}
        public partial class User_RoleRepository : BaseRepository<User_Role>, IUser_RoleRepository
		{

		}
        public partial class UserInfomationRepository : BaseRepository<UserInfomation>, IUserInfomationRepository
		{

		}
        public partial class WorkFlowRepository : BaseRepository<WorkFlow>, IWorkFlowRepository
		{

		}

}