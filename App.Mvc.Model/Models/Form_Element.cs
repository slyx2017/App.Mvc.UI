namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Form.Form_Element")]
    public partial class Form_Element
    {
        [Key]
        [Column(Order = 0)]
        public int FEId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormId { get; set; }

        public int? ElementId { get; set; }

        [StringLength(50)]
        public string FieldIden { get; set; }

        [StringLength(50)]
        public string ElementLable { get; set; }

        [StringLength(50)]
        public string ElementValid { get; set; }

        [StringLength(50)]
        public string ElementHeight { get; set; }

        [StringLength(200)]
        public string ElementDefValue { get; set; }

        public int? DataDictionary { get; set; }

        [StringLength(50)]
        public string ElementFormatType { get; set; }

        public int? ElementOrder { get; set; }
    }
}
