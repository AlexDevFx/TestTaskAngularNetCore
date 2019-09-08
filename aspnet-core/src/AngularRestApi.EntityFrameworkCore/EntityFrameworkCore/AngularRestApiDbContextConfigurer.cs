using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularRestApi.EntityFrameworkCore
{
    public static class AngularRestApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AngularRestApiDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AngularRestApiDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
