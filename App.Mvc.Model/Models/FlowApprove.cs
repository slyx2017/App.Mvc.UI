namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.FlowApprove")]
    public partial class FlowApprove
    {
        [Key]
        public int ApproveId { get; set; }

        public int? FlowInfoId { get; set; }

        [StringLength(100)]
        public string ApproveUser { get; set; }

        public int? FlowStepId { get; set; }

        public int? ApproveResult { get; set; }

        [StringLength(200)]
        public string ApproveRemark { get; set; }

        public DateTime? ApproveTime { get; set; }

        public int? ReallyApproveUser { get; set; }
    }
}
