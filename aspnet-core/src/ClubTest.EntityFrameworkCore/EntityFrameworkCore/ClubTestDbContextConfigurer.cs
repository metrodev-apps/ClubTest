using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ClubTest.EntityFrameworkCore
{
    public static class ClubTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ClubTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ClubTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
