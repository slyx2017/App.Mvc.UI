namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.WorkFlow")]
    public partial class WorkFlow
    {
        [Key]
        public int FlowID { get; set; }

        public int? FlowSort { get; set; }

        [StringLength(50)]
        public string FlowName { get; set; }

        public int? FormID { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        public int? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
