using ErfanLearn.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using ErfanLearn.Core.Convertors;

namespace ErfanLearn.Core.DTOs
{
    public class ChargeWalletViewModel
    {
        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public long Amount { get; set; }
    }

    public class WalletViewModel
    {
        public WalletTypes Type { get; set; }

        public string TypeDisplay => Type.ToDisplay();

        public string Description { get; set; }

        public long Amount { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
