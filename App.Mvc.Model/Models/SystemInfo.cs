namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.SystemInfo")]
    public partial class SystemInfo
    {
        [Key]
        public int System_ID { get; set; }

        [StringLength(100)]
        public string System_Title { get; set; }

        [StringLength(50)]
        public string System_Version { get; set; }

        [StringLength(100)]
        public string System_Copyright { get; set; }

        public bool? IsValidCode { get; set; }
    }
}
