using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ClubTest.Authorization.Roles;
using ClubTest.Authorization.Users;
using ClubTest.MultiTenancy;
using ClubTest.Domain;

namespace ClubTest.EntityFrameworkCore
{
    public class ClubTestDbContext : AbpZeroDbContext<Tenant, Role, User, ClubTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Team> Teams { get; set; }

        public ClubTestDbContext(DbContextOptions<ClubTestDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TeamConfig());
        }
    }
}
