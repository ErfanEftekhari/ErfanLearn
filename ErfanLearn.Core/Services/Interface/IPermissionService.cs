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


    }
}
