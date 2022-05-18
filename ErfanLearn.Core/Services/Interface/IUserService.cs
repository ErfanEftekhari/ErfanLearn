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

        User GetUserByEmail(string email);

        bool ResetPassword(ResetPasswordViewModel model);

        User GetUserByUserName(string username);



        #region User Panel

        InformationUserViewModel GetUserInformation(string username);

        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);

        EditProfileViewModel GetDataForEditProfileUser(string username);

        bool EditProfile(EditProfileViewModel model);

        bool CompareOldPassword(string userName, string oldPassword);
        void ChangeUserPassword(string userName, string password);

        #endregion

        #region Admin Panel

        UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");

        int AddUserByAdmin(CreateUserViewModel model);

        EditUserViewModel GetUserForShow(int userID);

        bool EditUSer(EditUserViewModel model);

        bool SoftDeleteUser(int userId);

        #endregion
    }
}
