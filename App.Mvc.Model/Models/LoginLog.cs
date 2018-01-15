namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.LoginLog")]
    public partial class LoginLog
    {
        [Key]
        [Column(Order = 0)]
        public int Login_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Login_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Login_Nicker { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Login_IP { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Login_Time { get; set; }
    }
}
