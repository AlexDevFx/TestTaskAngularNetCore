using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AngularRestApi.Configuration;
using AngularRestApi.Web;

namespace AngularRestApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AngularRestApiDbContextFactory : IDesignTimeDbContextFactory<AngularRestApiDbContext>
    {
        public AngularRestApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AngularRestApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AngularRestApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AngularRestApiConsts.ConnectionStringName));

            return new AngularRestApiDbContext(builder.Options);
        }
    }
}
