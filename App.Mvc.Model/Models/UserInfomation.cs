namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.UserInfomation")]
    public partial class UserInfomation
    {
        [Key]
        [Column(Order = 0)]
        public int User_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string User_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string User_Password { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string User_Reallyname { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(500)]
        public string HeadPortrait { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Department_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Create_Time { get; set; }

        public DateTime? Update_Time { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
