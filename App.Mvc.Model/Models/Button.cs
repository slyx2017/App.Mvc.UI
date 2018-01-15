namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Button")]
    public partial class Button
    {
        [Key]
        [Column(Order = 0)]
        public int Button_ID { get; set; }

        [StringLength(100)]
        public string Button_OpID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Button_Name { get; set; }

        [StringLength(100)]
        public string Button_Operation { get; set; }

        [StringLength(100)]
        public string Button_Magic { get; set; }

        [StringLength(100)]
        public string Button_Describe { get; set; }

        public DateTime? Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
