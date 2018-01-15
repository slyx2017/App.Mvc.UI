namespace App.Mvc.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Base.Role_Button")]
    public partial class Role_Button
    {
        public int ID { get; set; }

        public int? Role_ID { get; set; }

        public int? Menu_ID { get; set; }

        public int? Button_ID { get; set; }
    }
}
