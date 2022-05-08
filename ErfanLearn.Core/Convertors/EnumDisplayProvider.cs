using ErfanLearn.Enum;

namespace ErfanLearn.Core.Convertors
{
    public static class EnumDisplayProvider
    {
        public static string ToDisplay(this WalletTypes types)
        {
            string result = "";
            switch (types)
            {
                case WalletTypes.Deposit:
                    result = "واریز به حساب";
                    break;
                case WalletTypes.Withdraw:
                    result = "برداشت از حساب";
                    break;
                default:
                    result = "شناخته نشده";
                    break;
            }

            return result;
        }
    }
}
