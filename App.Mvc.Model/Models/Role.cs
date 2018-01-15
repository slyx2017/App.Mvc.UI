namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Role")]
    public partial class Role
    {
        [Key]
        [Column(Order = 0)]
        public int Role_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Role_Name { get; set; }

        [StringLength(500)]
        public string Role_Description { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
