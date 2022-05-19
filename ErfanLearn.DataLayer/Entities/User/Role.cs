using ErfanLearn.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ErfanLearn.DataLayer.Entities.User
{
   public class Role
    {
        public Role()
        {
            
        }

        [Key]
        public int RoleId { get; set; }

        [Display(Name = "نام نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RoleTitle { get; set; }

        [Display(Name = "وضعیت")]
        public Status Status { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }


        #endregion
    }
}
