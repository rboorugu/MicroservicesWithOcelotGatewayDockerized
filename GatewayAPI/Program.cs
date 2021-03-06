﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace GatewayAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: false)
           .Build();

            return WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .UseUrls(config["hostUrl"])
               .Build();
        }
    }
}
