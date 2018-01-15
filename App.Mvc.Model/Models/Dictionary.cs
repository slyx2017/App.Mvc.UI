namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Dictionary")]
    public partial class Dictionary
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DicCategoryID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string DicValue { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Enabled { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
