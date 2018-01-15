namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Message")]
    public partial class Message
    {
        [Key]
        [Column(Order = 0)]
        public int MessageID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string MessageTitle { get; set; }

        [Key]
        [Column(Order = 2)]
        public string MessageText { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SendUser { get; set; }

        [Key]
        [Column(Order = 4)]
        public string RecUser { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime SendTime { get; set; }

        public DateTime? ExpirationTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsSendEmail { get; set; }

        public int? SendEmailState { get; set; }
    }
}
