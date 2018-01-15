namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flow.FlowActive")]
    public partial class FlowActive
    {
        [Key]
        [Column(Order = 0)]
        public int ActiveId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlowId { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(100)]
        public string Viewfrom { get; set; }

        [StringLength(100)]
        public string Viewto { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string FlowLineName { get; set; }

        public bool? alt { get; set; }
    }
}
