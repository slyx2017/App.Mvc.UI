namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.DictionaryCategory")]
    public partial class DictionaryCategory
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Category { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Enabled { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
