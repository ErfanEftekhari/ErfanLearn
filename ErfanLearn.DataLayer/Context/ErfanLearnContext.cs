using Microsoft.EntityFrameworkCore;
using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.DataLayer.Context
{
   public class ErfanLearnContext:DbContext
    {

        public ErfanLearnContext(DbContextOptions<ErfanLearnContext> options):base(options)
        {
            
        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        #endregion

    }
}
