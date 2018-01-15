namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Form.FormInfo")]
    public partial class FormInfo
    {
        [Key]
        [Column(Order = 0)]
        public int FormId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FormName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DBName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string FieldKey { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        public DateTime? CreatTime { get; set; }
    }
}
