namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test.LeaveInfo")]
    public partial class LeaveInfo
    {
        [Key]
        public int leaveId { get; set; }

        [StringLength(50)]
        public string leavePeople { get; set; }

        public int? leaveDepartment { get; set; }

        public int? leaveDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? leaveStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? leaveEndDate { get; set; }

        [StringLength(1000)]
        public string remark { get; set; }
    }
}
