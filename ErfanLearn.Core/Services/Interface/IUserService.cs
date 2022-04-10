using ErfanLearn.DataLayer.Entities.User;
using ErfanLearn.Core.DTOs;

namespace ErfanLearn.Core.Services.Interface
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);

        bool IsExistEmail(string email);

        int CreateUser(User user);

        User LoginUser(LoginViewModel model);

        bool ActiveAccount(string activecode);
    }
}
