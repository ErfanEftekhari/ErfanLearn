using ErfanLearn.Core.DTOs;
using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Context;
using ErfanLearn.DataLayer.Entities.User;
using System.Linq;
using ErfanLearn.Core.Security;
using ErfanLearn.Core.Generator;

namespace ErfanLearn.Core.Services
{
    public class UserService : IUserService
    {
        private ErfanLearnContext _context;
        public UserService(ErfanLearnContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activecode)
        {
            var user = _context.Users.SingleOrDefault(x => x.ActiveCode == activecode);
            if(user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GeneratorUniqCode();
            _context.SaveChanges();
            return true;
        }

        public int CreateUser(User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();

            return user.UserId;

        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(x => x.Email.Trim().ToLower() == email.Trim().ToLower());
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(x => x.Email.Trim().ToLower() == email.Trim().ToLower());
        }
        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(x => x.Email.Trim().ToLower() == userName.Trim().ToLower());
        }

        public User LoginUser(LoginViewModel model)
        {
            string email = model.Email.Trim();
            string passWord = PasswordHelper.EncodePasswordMd5(model.Password);
            return _context.Users.SingleOrDefault(x => x.Email.ToUpper() == email.ToUpper() &&
                                                       x.Password == passWord);
        }

        public bool ResetPassword(ResetPasswordViewModel model)
        {
            var user = _context.Users.SingleOrDefault(x => x.ActiveCode == model.ActiveCode);
            
            if(user == null)
                return false;

            user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            user.ActiveCode = NameGenerator.GeneratorUniqCode();

            _context.SaveChanges();

            return true;
        }
    }
}
