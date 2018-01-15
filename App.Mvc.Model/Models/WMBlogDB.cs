namespace App.Mvc.Model.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WMBlogDB : DbContext
    {
        public WMBlogDB()
            : base("name=WMBlogDBContext")
        {
        }

        public virtual DbSet<Button> Button { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<DictionaryCategory> DictionaryCategory { get; set; }
        public virtual DbSet<LoginLog> LoginLog { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Menu_Button> Menu_Button { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Role_Button> Role_Button { get; set; }
        public virtual DbSet<Role_Menu> Role_Menu { get; set; }
        public virtual DbSet<SystemInfo> SystemInfo { get; set; }
        public virtual DbSet<User_Message> User_Message { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }
        public virtual DbSet<UserInfomation> UserInfomation { get; set; }
        public virtual DbSet<ActiveCondition> ActiveCondition { get; set; }
        public virtual DbSet<FlowActive> FlowActive { get; set; }
        public virtual DbSet<FlowApprove> FlowApprove { get; set; }
        public virtual DbSet<FlowInfo> FlowInfo { get; set; }
        public virtual DbSet<FlowStep> FlowStep { get; set; }
        public virtual DbSet<WorkFlow> WorkFlow { get; set; }
        public virtual DbSet<ElementInfo> ElementInfo { get; set; }
        public virtual DbSet<Form_Element> Form_Element { get; set; }
        public virtual DbSet<FormInfo> FormInfo { get; set; }
        public virtual DbSet<LeaveInfo> LeaveInfo { get; set; }
        public virtual DbSet<New> New { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictionary>()
                .Property(e => e.DicValue)
                .IsUnicode(false);

            modelBuilder.Entity<DictionaryCategory>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageText)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.RecUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfomation>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfomation>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveCondition>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveCondition>()
                .Property(e => e.Compare)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveCondition>()
                .Property(e => e.CompareValue)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveCondition>()
                .Property(e => e.Logic)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveCondition>()
                .Property(e => e.Combine)
                .IsUnicode(false);

            modelBuilder.Entity<FlowActive>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<FlowActive>()
                .Property(e => e.Viewfrom)
                .IsUnicode(false);

            modelBuilder.Entity<FlowActive>()
                .Property(e => e.Viewto)
                .IsUnicode(false);

            modelBuilder.Entity<FlowActive>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<FlowActive>()
                .Property(e => e.FlowLineName)
                .IsUnicode(false);

            modelBuilder.Entity<FlowApprove>()
                .Property(e => e.ApproveUser)
                .IsUnicode(false);

            modelBuilder.Entity<FlowApprove>()
                .Property(e => e.ApproveRemark)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.stepUser)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.stepName)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.flowNodeName)
                .IsUnicode(false);

            modelBuilder.Entity<FlowStep>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.FlowName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<ElementInfo>()
                .Property(e => e.ElementText)
                .IsUnicode(false);

            modelBuilder.Entity<ElementInfo>()
                .Property(e => e.ElementIoc)
                .IsUnicode(false);

            modelBuilder.Entity<ElementInfo>()
                .Property(e => e.ElementType)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.FieldIden)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.ElementLable)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.ElementValid)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.ElementHeight)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.ElementDefValue)
                .IsUnicode(false);

            modelBuilder.Entity<Form_Element>()
                .Property(e => e.ElementFormatType)
                .IsUnicode(false);

            modelBuilder.Entity<FormInfo>()
                .Property(e => e.FormName)
                .IsUnicode(false);

            modelBuilder.Entity<FormInfo>()
                .Property(e => e.DBName)
                .IsUnicode(false);

            modelBuilder.Entity<FormInfo>()
                .Property(e => e.FieldKey)
                .IsUnicode(false);

            modelBuilder.Entity<FormInfo>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveInfo>()
                .Property(e => e.leavePeople)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveInfo>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<New>()
                .Property(e => e.NewTitle)
                .IsUnicode(false);

            modelBuilder.Entity<New>()
                .Property(e => e.NewContent)
                .IsUnicode(false);

            modelBuilder.Entity<New>()
                .Property(e => e.NewAuthor)
                .IsUnicode(false);
        }
    }
}
