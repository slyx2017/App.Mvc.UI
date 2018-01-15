namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Menu")]
    public partial class Menu
    {
        [Key]
        [Column(Order = 0)]
        public int Menu_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Menu_Name { get; set; }

        [StringLength(200)]
        public string Menu_Url { get; set; }

        public int? Menu_ParentID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Menu_Order { get; set; }

        [StringLength(100)]
        public string Menu_Icon { get; set; }

        public int? IsVisible { get; set; }

        public DateTime? Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }
    }
}
