using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ErfanLearn.Enum;
using System.Collections.Generic;
using ErfanLearn.Core.DTOs;
using ErfanLearn.DataLayer.Entities.Wallet;

namespace ErfanLearn.Core.Services
{
    public class WalletService : IWalletService
    {
        private ErfanLearnContext _context;

        public WalletService(ErfanLearnContext context)
        {
            _context = context;
        }

        public Wallet GetWalletById(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public int ChargeWallet(string userName, long Amount, string description, bool isPay = false)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == userName);

            var wallet = new Wallet()
            {
                Amount = Amount,
                CreateDate = System.DateTime.Now,
                UserId = user.UserId,
                Type = WalletTypes.Deposit,
                PayStatus = isPay,
                Description = description
            };

            _context.Wallets.Add(wallet);
            _context.SaveChanges();

            return wallet.WalletId;
        }

        public List<WalletViewModel> GetWalletUser(string userName)
         => _context.Wallets.Include(x => x.User).Where(x => x.User.UserName == userName)
                                               .Where(x => x.PayStatus != false)
                                               .Select(x => new WalletViewModel()
                                               {
                                                   Amount = x.Amount,
                                                   Type = x.Type,
                                                   Description = x.Description,
                                                   CreateDate = x.CreateDate,
                                               }).ToList();

        public long WalletBalance(string userName)
        {
            var Withdraw = _context.Wallets.Include(x => x.User).Where(x => x.User.UserName == userName)
                                                              .Where(x => x.Type == WalletTypes.Withdraw)
                                                              .Where(x => x.PayStatus != false)
                                                              .Select(x => x.Amount).ToList();

            var Deposit = _context.Wallets.Include(x => x.User).Where(x => x.User.UserName == userName)
                                                              .Where(x => x.Type == WalletTypes.Deposit)
                                                              .Where(x => x.PayStatus != false)
                                                              .Select(x => x.Amount).ToList();
            return (Deposit.Sum() - Withdraw.Sum());
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }
    }
}
