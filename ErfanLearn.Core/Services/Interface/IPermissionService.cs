using ErfanLearn.DataLayer.Entities.Permission;
using ErfanLearn.DataLayer.Entities.User;
using System.Collections.Generic;

namespace ErfanLearn.Core.Services.Interface
{
    public interface IPermissionService
    {
        List<Role> GetRoles();

        bool AddRolesToUser(List<int> roles,int userId);

        bool EditRolesUser(List<int> roles, int userId);

        int CreateRole(Role role);

        Role GetRoleById(int roleId);

        bool EditRole(Role role);

        bool SoftDeleteRole(int roleId);

        List<Permission> GetPermissions();

        List<int> GetPermissionsByRoleId(int roleId);

        bool AddPermissionsToRole(List<int> permissions, int roleId);

        bool EditPermissionsToRole(List<int> permissions, int roleId);

        bool CheckPermission(string permissionName , string userName);




    }
}
