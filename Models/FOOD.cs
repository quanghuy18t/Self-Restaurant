namespace Manage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOOD")]
    public partial class FOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOOD()
        {
            ORDERDETAILs = new HashSet<ORDERDETAIL>();
            SERVEs = new HashSet<SERVE>();
        }

        [Key]
        public int idFood { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên món ăn")]
        public string name { get; set; }

        [StringLength(100)]
        [Display(Name = "Ảnh món ăn")]
        public string image { get; set; }

        [Display(Name = "Giá món ăn")]
        public int? price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERDETAIL> ORDERDETAILs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVE> SERVEs { get; set; }
    }
}
