//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Mvc.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlowApprove
    {
        public int ApproveId { get; set; }
        public Nullable<int> FlowInfoId { get; set; }
        public string ApproveUser { get; set; }
        public Nullable<int> FlowStepId { get; set; }
        public Nullable<int> ApproveResult { get; set; }
        public string ApproveRemark { get; set; }
        public Nullable<System.DateTime> ApproveTime { get; set; }
        public Nullable<int> ReallyApproveUser { get; set; }
    }
}
