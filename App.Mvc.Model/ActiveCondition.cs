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
    
    public partial class ActiveCondition
    {
        public int ConditionId { get; set; }
        public Nullable<int> ActiveId { get; set; }
        public Nullable<int> FlowId { get; set; }
        public Nullable<int> ConditionIndex { get; set; }
        public string Field { get; set; }
        public string Compare { get; set; }
        public string CompareValue { get; set; }
        public string Logic { get; set; }
        public string Combine { get; set; }
    }
}
