namespace Manage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIFTCARD")]
    public partial class GIFTCARD
    {
        [Key]
        public int idCard { get; set; }

        public int idUser { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên chủ thẻ")]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Số điện thoại chủ thẻ")]
        public string phone { get; set; }

        [Display(Name = "Điểm thưởng")]
        public int? point { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime? create_at { get; set; }

        public virtual USER USER { get; set; }
    }
}
