using System.Collections.Generic;
using ErfanLearn.Core.DTOs;
using ErfanLearn.DataLayer.Entities.Wallet;

namespace ErfanLearn.Core.Services.Interface
{
    public interface IWalletService
    {
        long WalletBalance(string userName);

        List<WalletViewModel> GetWalletUser(string userName);

        int ChargeWallet(string userName, long Amount, string description, bool isPay = false);

        Wallet GetWalletById(int walletid);

        void UpdateWallet(Wallet wallet);
    }
}
