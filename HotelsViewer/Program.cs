using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HotelsViewer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //added to support EF
                .ConfigureAppConfiguration(SetupCofiguration)
                .UseStartup<Startup>();

        private static void SetupCofiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //Remove default configuration options
            builder.Sources.Clear();

            builder.AddJsonFile("config.json", false, true)
                .AddEnvironmentVariables();
        }
    }
}
