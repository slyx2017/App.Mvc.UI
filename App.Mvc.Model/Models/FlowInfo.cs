namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.FlowInfo")]
    public partial class FlowInfo
    {
        public int FlowInfoId { get; set; }

        public int? FlowId { get; set; }

        public int? FormId { get; set; }

        public int? FormInfoId { get; set; }

        public int? UserId { get; set; }

        public int? FlowStepId { get; set; }

        public int? FlowInfoState { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
