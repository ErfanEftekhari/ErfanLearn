using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Context;
using ErfanLearn.DataLayer.Entities.User;
using System.Linq;

namespace ErfanLearn.Core.Services
{
    public class UserService : IUserService
    {
        private  ErfanLearnContext _context;
        public UserService(ErfanLearnContext context)
        {
            _context = context;
        }

        public int CreateUser(User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();
            
            return user.UserId;

        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(x => x.Email.Trim().ToLower() == email.Trim().ToLower());
        }
        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(x => x.Email.Trim().ToLower() == userName.Trim().ToLower());
        }
    }
}
