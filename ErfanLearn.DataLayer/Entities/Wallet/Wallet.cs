using ErfanLearn.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ErfanLearn.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {

        }

        [Key]
        public int WalletId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }

        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public WalletTypes Type { get; set; }

        [Display(Name = "شرح تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Description { get; set; }

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public long Amount { get; set; }

        [Display(Name = "وضعیت پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool PayStatus { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime CreateDate { get; set; }


        #region Relations

        public virtual User.User User { get; set; }

        #endregion
    }
}
