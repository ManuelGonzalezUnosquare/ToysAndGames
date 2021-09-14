using App.Metrics.AspNetCore;
using App.Metrics.Formatters.Prometheus;
using App.Metrics.Logging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToysAndGames
{
    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
          WebHost.CreateDefaultBuilder(args)
              .UseKestrel(o =>
              {
                  o.AllowSynchronousIO = true;
                  o.Limits.MaxRequestBodySize = null;
                  o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(240);
                  o.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(240);
              })
              .UseIIS()
              .UseIISIntegration()
              .UseMetrics()
              .UseMetricsWebTracking()
              .UseMetricsEndpoints(options =>
              {
                  options.MetricsEndpointOutputFormatter = new MetricsPrometheusTextOutputFormatter();
              })
              .UseDefaultServiceProvider((context, options) =>
              {
                  options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
                  options.ValidateOnBuild = true;
              })
              .UseStartup<Startup>();

        public static void Main(string[] args)
        {
            var hostBuilder = CreateWebHostBuilder(args);

         //   hostBuilder = hostBuilder.UseUrls($"http://0.0.0.0:{ConfigUtils.GetEnvironmentVariableOrDefault(args, "API_PORT", 9000)}");

            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            //var log = DISetup.ServiceProvider.GetService<ILog>();
            //log.Info($" baseDir = {baseDir}");

            hostBuilder = hostBuilder.UseContentRoot(baseDir);

            var host = hostBuilder.Build();

            host.Run();
        }
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
