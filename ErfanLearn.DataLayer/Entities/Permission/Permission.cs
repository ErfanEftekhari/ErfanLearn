using ErfanLearn.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErfanLearn.DataLayer.Entities.Permission
{
    public class Permission
    {
        public Permission()
        {

        }

        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "عنوان دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string PermissionTitle { get; set; }

        [Display(Name = "نام دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }

        [Display(Name = "وضعیت")]
        public Status Status { get; set; }

        public int? ParentId { get; set; }


        #region Relations

        [ForeignKey("ParentId")]
        public virtual List<Permission> Permissions { get; set; }

        public virtual List<RolePermission> RolePermissions { get; set; }

        #endregion
    }
}
