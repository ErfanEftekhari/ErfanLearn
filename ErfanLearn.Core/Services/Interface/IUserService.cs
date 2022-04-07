using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.Core.Services.Interface
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);

        bool IsExistEmail(string email);

        int CreateUser(User user);
    }
}
