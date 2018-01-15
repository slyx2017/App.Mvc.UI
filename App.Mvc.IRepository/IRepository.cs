
using App.Mvc.IRepository.Base;
using App.Mvc.Model.Models;
namespace App.Mvc.IRepository
{
    //在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。

        public partial interface IActiveConditionRepository : IBaseRepository<ActiveCondition>
		{

		}
        public partial interface IButtonRepository : IBaseRepository<Button>
		{

		}
        public partial interface IDictionaryRepository : IBaseRepository<Dictionary>
		{

		}
        public partial interface IDictionaryCategoryRepository : IBaseRepository<DictionaryCategory>
		{

		}
        public partial interface IElementInfoRepository : IBaseRepository<ElementInfo>
		{

		}
        public partial interface IFlowActiveRepository : IBaseRepository<FlowActive>
		{

		}
        public partial interface IFlowApproveRepository : IBaseRepository<FlowApprove>
		{

		}
        public partial interface IFlowInfoRepository : IBaseRepository<FlowInfo>
		{

		}
        public partial interface IFlowStepRepository : IBaseRepository<FlowStep>
		{

		}
        public partial interface IForm_ElementRepository : IBaseRepository<Form_Element>
		{

		}
        public partial interface IFormInfoRepository : IBaseRepository<FormInfo>
		{

		}
        public partial interface ILeaveInfoRepository : IBaseRepository<LeaveInfo>
		{

		}
        public partial interface ILoginLogRepository : IBaseRepository<LoginLog>
		{

		}
        public partial interface IMenuRepository : IBaseRepository<Menu>
		{

		}
        public partial interface IMenu_ButtonRepository : IBaseRepository<Menu_Button>
		{

		}
        public partial interface IMessageRepository : IBaseRepository<Message>
		{

		}
        public partial interface INewRepository : IBaseRepository<New>
		{

		}
        public partial interface IRoleRepository : IBaseRepository<Role>
		{

		}
        public partial interface IRole_ButtonRepository : IBaseRepository<Role_Button>
		{

		}
        public partial interface IRole_MenuRepository : IBaseRepository<Role_Menu>
		{

		}
        public partial interface ISystemInfoRepository : IBaseRepository<SystemInfo>
		{

		}
        public partial interface IUser_MessageRepository : IBaseRepository<User_Message>
		{

		}
        public partial interface IUser_RoleRepository : IBaseRepository<User_Role>
		{

		}
        public partial interface IUserInfomationRepository : IBaseRepository<UserInfomation>
		{

		}
        public partial interface IWorkFlowRepository : IBaseRepository<WorkFlow>
		{

		}

}