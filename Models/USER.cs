namespace Manage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            GIFTCARDs = new HashSet<GIFTCARD>();
            SERVEs = new HashSet<SERVE>();
        }

        [Key]
        public int idUser { get; set; }

        [Display(Name = "Vai trò")]
        public int idRole { get; set; }

        [Display(Name = "Chi nhánh")]
        public int? idBranch { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên nhân viên")]
        public string name { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tài khoản")]
        public string userName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string passWord { get; set; }

        public virtual BRANCH BRANCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIFTCARD> GIFTCARDs { get; set; }

        public virtual ROLE ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVE> SERVEs { get; set; }
    }
}
