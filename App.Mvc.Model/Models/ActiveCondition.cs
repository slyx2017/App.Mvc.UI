namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.ActiveCondition")]
    public partial class ActiveCondition
    {
        [Key]
        public int ConditionId { get; set; }

        public int? ActiveId { get; set; }

        public int? FlowId { get; set; }

        public int? ConditionIndex { get; set; }

        [StringLength(100)]
        public string Field { get; set; }

        [StringLength(100)]
        public string Compare { get; set; }

        [StringLength(200)]
        public string CompareValue { get; set; }

        [StringLength(50)]
        public string Logic { get; set; }

        [StringLength(500)]
        public string Combine { get; set; }
    }
}
