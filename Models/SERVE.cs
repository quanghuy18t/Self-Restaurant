namespace Manage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVE")]
    public partial class SERVE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFood { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public virtual FOOD FOOD { get; set; }

        public virtual USER USER { get; set; }
    }
}
