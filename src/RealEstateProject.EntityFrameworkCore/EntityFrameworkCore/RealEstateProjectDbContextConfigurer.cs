using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RealEstateProject.EntityFrameworkCore
{
    public static class RealEstateProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RealEstateProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RealEstateProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
