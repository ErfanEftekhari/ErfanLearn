using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;

namespace ErfanLearn.Web.Controllers
{
    public class HomeController : Controller
    {
        private IWalletService _walletService;
        public HomeController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("OnlinePayment/{walletId}")]
        public IActionResult OnlinePayment(int walletId)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _walletService.GetWalletById(walletId);

                var payment = new ZarinpalSandbox.Payment((int)wallet.Amount);

                var Response = payment.Verification(authority);

                if(Response.Result.Status == 100)
                {
                    ViewBag.Code = Response.Result.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.PayStatus = true;
                    _walletService.UpdateWallet(wallet);
                }

            }
            return View();
        }
    }
}
