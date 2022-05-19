using ErfanLearn.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ErfanLearn.DataLayer.Entities.Permission
{
    public class RolePermission
    {

        public RolePermission()
        {

        }

        [Key]
        public int RP_Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }


        #region Relations

        public virtual Role Role { get; set; }
        public virtual Permission Permission { get; set; }

        #endregion
    }
}
