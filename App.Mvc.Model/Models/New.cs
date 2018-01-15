namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test.New")]
    public partial class New
    {
        public int NewId { get; set; }

        [StringLength(50)]
        public string NewTitle { get; set; }

        [StringLength(200)]
        public string NewContent { get; set; }

        [StringLength(50)]
        public string NewAuthor { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
