using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Entities.User;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Context;
using System.Linq;

namespace ErfanLearn.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private ErfanLearnContext _context;
        public PermissionService(ErfanLearnContext context)
        {
            _context = context;
        }

        public bool AddRolesToUser(List<int> roles,int userId)
        {
            if(!roles.Any())
            {
                return false;
            }
            List<UserRole> userRoles = new List<UserRole>();

            foreach (var item in roles)
            {
                userRoles.Add(new UserRole
                {
                    RoleId = item,
                    UserId = userId
                });
            }

            try
            {
                _context.UserRoles.AddRange(userRoles);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }

            return true;
        }

        public int CreateRole(Role role)
        {
            role.Status = Enum.Status.Enabled;
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public bool EditRole(Role role)
        {
            if (role == null)
                return false;

            _context.Roles.Update(role);
            _context.SaveChanges();

            return true;
        }

        public bool EditRolesUser(List<int> roles, int userId)
        {
            _context.UserRoles.Where(x=>x.UserId == userId).ToList()
                .ForEach(x => _context.UserRoles.Remove(x));

            return AddRolesToUser(roles,userId);
        }

        public Role GetRoleById(int roleId)
            => _context.Roles.Find(roleId);

        public List<Role> GetRoles()
            => _context.Roles.ToList();

        public bool SoftDeleteRole(int roleId)
        {
            var role = GetRoleById(roleId);
            role.Status = Enum.Status.IsDeleted;
            if(EditRole(role))
                return true;

            return false;

        }
    }
}