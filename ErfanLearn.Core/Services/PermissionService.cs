using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Entities.User;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Context;
using System.Linq;
using ErfanLearn.DataLayer.Entities.Permission;
using Microsoft.EntityFrameworkCore;

namespace ErfanLearn.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private ErfanLearnContext _context;
        public PermissionService(ErfanLearnContext context)
        {
            _context = context;
        }

        public bool AddPermissionsToRole(List<int> permissions, int roleId)
        {
            if (!permissions.Any())
            {
                return false;
            }
            List<RolePermission> rolePermissions = new List<RolePermission>();

            foreach (var item in permissions)
            {
                rolePermissions.Add(new RolePermission
                {
                    PermissionId = item,
                    RoleId = roleId
                });
            }

            try
            {
                _context.RolePermissions.AddRange(rolePermissions);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }

            return true;
        }

        public bool AddRolesToUser(List<int> roles, int userId)
        {
            if (!roles.Any())
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

        public bool CheckPermission(string permissionName, string userName)
        {
            var userRole = _context.UserRoles.Include(x => x.User)
                                             .Where(x => x.User.UserName == userName)
                                             .Select(x => x.RoleId)
                                             .ToList();
            if (!userRole.Any())
                return false;
            var rolePermission = _context.RolePermissions.Include(x => x.Permission)
                                                         .Where(x => x.Permission.Name == permissionName)
                                                         .Select(x => x.RoleId)
                                                         .ToList();
            if (!rolePermission.Any())
                return false;

            return userRole.Any(x => rolePermission.Contains(x));
        }

        public int CreateRole(Role role)
        {
            role.Status = Enum.Status.Enabled;
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public bool EditPermissionsToRole(List<int> permissions, int roleId)
        {
            _context.RolePermissions.Where(x => x.RoleId == roleId).ToList()
                .ForEach(x => _context.RolePermissions.Remove(x));

            return AddPermissionsToRole(permissions, roleId);
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
            _context.UserRoles.Where(x => x.UserId == userId).ToList()
                .ForEach(x => _context.UserRoles.Remove(x));

            return AddRolesToUser(roles, userId);
        }

        public List<Permission> GetPermissions()
            => _context.Permissions.ToList();

        public List<int> GetPermissionsByRoleId(int roleId)
            => _context.RolePermissions.Where(x => x.RoleId == roleId)
                                    .Select(x => x.PermissionId)
                                    .ToList();

        public Role GetRoleById(int roleId)
            => _context.Roles.Find(roleId);

        public List<Role> GetRoles()
            => _context.Roles.ToList();

        public bool SoftDeleteRole(int roleId)
        {
            var role = GetRoleById(roleId);
            role.Status = Enum.Status.IsDeleted;
            if (EditRole(role))
                return true;

            return false;

        }
    }
}