using Microsoft.EntityFrameworkCore;
using ErfanLearn.DataLayer.Entities.User;
using ErfanLearn.DataLayer.Entities.Wallet;
using ErfanLearn.DataLayer.Entities.Permission;
using ErfanLearn.DataLayer.Entities.Course;

namespace ErfanLearn.DataLayer.Context
{
    public class ErfanLearnContext : DbContext
    {

        public ErfanLearnContext(DbContextOptions<ErfanLearnContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        #endregion

        #region Wallet

        public DbSet<Wallet> Wallets { get; set; }

        #endregion

        #region Permission
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        #endregion

        #region 
        public DbSet<CourseGroup> courseGroups { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasQueryFilter(x => x.Status != Enum.Status.IsDeleted);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(x => x.Status != Enum.Status.IsDeleted);
            modelBuilder.Entity<Permission>()
                .HasQueryFilter(x => x.Status != Enum.Status.IsDeleted);
            modelBuilder.Entity<CourseGroup>()
                .HasQueryFilter(x => x.Status != Enum.Status.IsDeleted);
            base.OnModelCreating(modelBuilder);
        }
    }
}
