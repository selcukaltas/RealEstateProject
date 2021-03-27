using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RealEstateProject.Configuration;
using RealEstateProject.Web;

namespace RealEstateProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RealEstateProjectDbContextFactory : IDesignTimeDbContextFactory<RealEstateProjectDbContext>
    {
        public RealEstateProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RealEstateProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RealEstateProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RealEstateProjectConsts.ConnectionStringName));

            return new RealEstateProjectDbContext(builder.Options);
        }
    }
}
