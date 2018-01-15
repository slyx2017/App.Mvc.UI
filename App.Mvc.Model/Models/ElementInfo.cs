namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Form.ElementInfo")]
    public partial class ElementInfo
    {
        [Key]
        public int ElementId { get; set; }

        [StringLength(50)]
        public string ElementText { get; set; }

        [StringLength(100)]
        public string ElementIoc { get; set; }

        [StringLength(100)]
        public string ElementType { get; set; }
    }
}
