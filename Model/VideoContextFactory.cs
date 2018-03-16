using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VideoTracker.Model
{
    public class VideoContextFactory : IDesignTimeDbContextFactory<VideoTrackerContext>
    {
        public VideoTrackerContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<VideoTrackerContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("VideoTrackerContext"));

            return new VideoTrackerContext(optionsBuilder.Options);
        }
    }
}
