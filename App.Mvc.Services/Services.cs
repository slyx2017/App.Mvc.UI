
using App.Mvc.IRepository;
using App.Mvc.IServices;
using App.Mvc.Model.Models;
using App.Mvc.Services.Base;
namespace App.Mvc.Services
{
    public partial class ActiveConditionServices : BaseServices<ActiveCondition>, IActiveConditionServices
	{
        IActiveConditionRepository dal;
        public ActiveConditionServices(IActiveConditionRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class ButtonServices : BaseServices<Button>, IButtonServices
	{
        IButtonRepository dal;
        public ButtonServices(IButtonRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class DictionaryServices : BaseServices<Dictionary>, IDictionaryServices
	{
        IDictionaryRepository dal;
        public DictionaryServices(IDictionaryRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class DictionaryCategoryServices : BaseServices<DictionaryCategory>, IDictionaryCategoryServices
	{
        IDictionaryCategoryRepository dal;
        public DictionaryCategoryServices(IDictionaryCategoryRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class ElementInfoServices : BaseServices<ElementInfo>, IElementInfoServices
	{
        IElementInfoRepository dal;
        public ElementInfoServices(IElementInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class FlowActiveServices : BaseServices<FlowActive>, IFlowActiveServices
	{
        IFlowActiveRepository dal;
        public FlowActiveServices(IFlowActiveRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class FlowApproveServices : BaseServices<FlowApprove>, IFlowApproveServices
	{
        IFlowApproveRepository dal;
        public FlowApproveServices(IFlowApproveRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class FlowInfoServices : BaseServices<FlowInfo>, IFlowInfoServices
	{
        IFlowInfoRepository dal;
        public FlowInfoServices(IFlowInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class FlowStepServices : BaseServices<FlowStep>, IFlowStepServices
	{
        IFlowStepRepository dal;
        public FlowStepServices(IFlowStepRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class Form_ElementServices : BaseServices<Form_Element>, IForm_ElementServices
	{
        IForm_ElementRepository dal;
        public Form_ElementServices(IForm_ElementRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class FormInfoServices : BaseServices<FormInfo>, IFormInfoServices
	{
        IFormInfoRepository dal;
        public FormInfoServices(IFormInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class LeaveInfoServices : BaseServices<LeaveInfo>, ILeaveInfoServices
	{
        ILeaveInfoRepository dal;
        public LeaveInfoServices(ILeaveInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class LoginLogServices : BaseServices<LoginLog>, ILoginLogServices
	{
        ILoginLogRepository dal;
        public LoginLogServices(ILoginLogRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class MenuServices : BaseServices<Menu>, IMenuServices
	{
        IMenuRepository dal;
        public MenuServices(IMenuRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class Menu_ButtonServices : BaseServices<Menu_Button>, IMenu_ButtonServices
	{
        IMenu_ButtonRepository dal;
        public Menu_ButtonServices(IMenu_ButtonRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class MessageServices : BaseServices<Message>, IMessageServices
	{
        IMessageRepository dal;
        public MessageServices(IMessageRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class NewServices : BaseServices<New>, INewServices
	{
        INewRepository dal;
        public NewServices(INewRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class RoleServices : BaseServices<Role>, IRoleServices
	{
        IRoleRepository dal;
        public RoleServices(IRoleRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class Role_ButtonServices : BaseServices<Role_Button>, IRole_ButtonServices
	{
        IRole_ButtonRepository dal;
        public Role_ButtonServices(IRole_ButtonRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class Role_MenuServices : BaseServices<Role_Menu>, IRole_MenuServices
	{
        IRole_MenuRepository dal;
        public Role_MenuServices(IRole_MenuRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class SystemInfoServices : BaseServices<SystemInfo>, ISystemInfoServices
	{
        ISystemInfoRepository dal;
        public SystemInfoServices(ISystemInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class User_MessageServices : BaseServices<User_Message>, IUser_MessageServices
	{
        IUser_MessageRepository dal;
        public User_MessageServices(IUser_MessageRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class User_RoleServices : BaseServices<User_Role>, IUser_RoleServices
	{
        IUser_RoleRepository dal;
        public User_RoleServices(IUser_RoleRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class UserInfomationServices : BaseServices<UserInfomation>, IUserInfomationServices
	{
        IUserInfomationRepository dal;
        public UserInfomationServices(IUserInfomationRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}
    public partial class WorkFlowServices : BaseServices<WorkFlow>, IWorkFlowServices
	{
        IWorkFlowRepository dal;
        public WorkFlowServices(IWorkFlowRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
	}

}