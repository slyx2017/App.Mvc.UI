namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.FlowStep")]
    public partial class FlowStep
    {
        [Key]
        public int StepId { get; set; }

        public int? FlowId { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? Viewleft { get; set; }

        public int? Viewtop { get; set; }

        [StringLength(100)]
        public string type { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public bool? alt { get; set; }

        [StringLength(100)]
        public string stepUser { get; set; }

        [StringLength(100)]
        public string stepName { get; set; }

        [StringLength(100)]
        public string flowNodeName { get; set; }

        [StringLength(100)]
        public string remark { get; set; }
    }
}
