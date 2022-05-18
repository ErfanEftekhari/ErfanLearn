using ErfanLearn.Core.DTOs;
using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Context;
using ErfanLearn.DataLayer.Entities.User;
using System.Linq;
using ErfanLearn.Core.Security;
using ErfanLearn.Core.Generator;
using System.IO;
using ErfanLearn.Enum;

namespace ErfanLearn.Core.Services
{
    public class UserService : IUserService
    {
        private ErfanLearnContext _context;
        public IWalletService _walletService;
        public UserService(ErfanLearnContext context, IWalletService walletService)
        {
            _context = context;
            _walletService = walletService;
        }

        public bool ActiveAccount(string activecode)
        {
            var user = _context.Users.SingleOrDefault(x => x.ActiveCode == activecode);
            if (user == null || user.Status == Enum.Status.Enabled)
                return false;

            user.Status = Enum.Status.Enabled;
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

            if (user == null)
                return false;

            user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            user.ActiveCode = NameGenerator.GeneratorUniqCode();

            _context.SaveChanges();

            return true;
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);
            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = _walletService.WalletBalance(username);

            return information;

        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string username)
            => _context.Users.Where(x => x.UserName == username)
                                 .Select(x => new SideBarUserPanelViewModel()
                                 {
                                     UserName = x.UserName,
                                     RegisterDate = x.RegisterDate,
                                     ImageName = x.UserAvatar

                                 }).Single();

        public EditProfileViewModel GetDataForEditProfileUser(string username)
            => _context.Users.Where(x => x.UserName == username)
                                 .Select(x => new EditProfileViewModel()
                                 {
                                     UserName = x.UserName,
                                     Email = x.Email,
                                     AvatarName = x.UserAvatar
                                 }).Single();

        public bool EditProfile(EditProfileViewModel model)
        {
            string imgName = "";
            if (model.UserAvatar != null)
            {
                string imgPath = "";

                if (model.UserAvatar.FileName != model.AvatarName)
                {
                    imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", model.AvatarName);

                    if (File.Exists(imgPath))
                        File.Delete(imgPath);

                }

                imgName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(model.UserAvatar.FileName);

                imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", imgName);

                using (var stream = new FileStream(imgPath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(stream);
                }
            }

            var user = GetUserByUserName(model.LastUserName);

            user.UserName = model.UserName;
            user.Email = model.Email;
            user.UserAvatar = string.IsNullOrWhiteSpace(imgName) ? model.AvatarName : imgName;

            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public bool CompareOldPassword(string userName, string oldPassword)
        {
            var hashPass = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(x => x.UserName == userName &&
                                           x.Password == hashPass);
        }

        public void ChangeUserPassword(string userName, string password)
        {
            var user = GetUserByUserName(userName);
            user.Password = PasswordHelper.EncodePasswordMd5(password);
            _context.Update(user);
            _context.SaveChanges();

        }

        public UserForAdminViewModel GetUsers(int page = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> query = _context.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                query = query.Where(x => x.Email.Contains(filterEmail));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                query = query.Where(x => x.UserName.Contains(filterUserName));
            }


            int take = 10;
            int skip = (page - 1) * take;

            UserForAdminViewModel model = new UserForAdminViewModel();
            
            model.CurrentPage = page;

            model.PageCount = query.Count() % take == 0 ? query.Count() / take : (query.Count() / take) + 1; 

            model.Users = query.OrderBy(x => x.RegisterDate).Skip(skip).Take(take).ToList();

            return model;
        }

        public int AddUserByAdmin(CreateUserViewModel model)
        {
            var user = new User();
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            user.RegisterDate = System.DateTime.Now;
            user.ActiveCode = NameGenerator.GeneratorUniqCode();
            user.Status = Enum.Status.Enabled;

            #region Avatar
            string imgName = "";
            if (model.UserAvatar != null)
            {
                string imgPath = "";

                imgName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(model.UserAvatar.FileName);

                imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", imgName);

                using (var stream = new FileStream(imgPath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(stream);
                }
            }

            #endregion

            user.UserAvatar = string.IsNullOrWhiteSpace(imgName) ? "Defult.jpg" : imgName;

            return CreateUser(user);
        }

        public EditUserViewModel GetUserForShow(int userID)
            => _context.Users.Where(u => u.UserId == userID)
                .Select(u => new EditUserViewModel()
                {
                    UserId = u.UserId,
                    AvatarNAme = u.UserAvatar,
                    Email = u.Email,
                    UserName = u.UserName,
                    UserRoles = u.UserRoles.Select(r => r.RoleId).ToList(),
                    IsActive = u.Status == Enum.Status.Enabled ? true : false,
                }).Single();

        public bool EditUSer(EditUserViewModel model)
        {
            var user = _context.Users.Find(model.UserId);
            
            if (user == null)
                return false;

            user.Email = model.Email;
            if(!string.IsNullOrEmpty(model.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(model.Password);
            }


            string imgName = "";
            if (model.UserAvatar != null)
            {
                string imgPath = "";

                if (model.UserAvatar.FileName != model.AvatarNAme)
                {
                    imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", model.AvatarNAme);

                    if (File.Exists(imgPath))
                        File.Delete(imgPath);

                }

                imgName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(model.UserAvatar.FileName);

                imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", imgName);

                using (var stream = new FileStream(imgPath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(stream);
                }
            }

            user.UserAvatar = string.IsNullOrWhiteSpace(imgName) ? model.AvatarNAme : imgName;
            user.Status = model.IsActive == true ? Enum.Status.Enabled : Enum.Status.Disabled;
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;


        }

        public bool SoftDeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
                return false;

            user.Status = Status.IsDeleted;

            _context.Update(user);

            _context.SaveChanges();

            return true;
        }
    }
}
