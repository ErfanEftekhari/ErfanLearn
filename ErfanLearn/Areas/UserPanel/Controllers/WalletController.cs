using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;
using ErfanLearn.Core.DTOs;

namespace ErfanLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IWalletService _walletService;
        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _walletService.GetWalletUser(User.Identity.Name);
            ViewBag.Balance = _walletService.WalletBalance(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.ListWallet = _walletService.GetWalletUser(User.Identity.Name);
                ViewBag.Balance = _walletService.WalletBalance(User.Identity.Name);
                return View(model);
            }

            int walletId = _walletService.ChargeWallet(User.Identity.Name , model.Amount,"شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment((int)model.Amount);

            var response = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44367/OnlinePayment/"+walletId);

            if (response.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + response.Result.Authority);
            }
            #endregion

            return null;
        }
    }
}
