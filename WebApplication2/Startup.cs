using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Serilog.AspNetCore;

using Newtonsoft.Json;

using WebApplication2.Model;

namespace WebApplication2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            
            app.UseRouting();

            //app.UseAuthorization();

            app.Use(next => context =>
            {
                var endpoint = context.GetEndpoint();
                var routevalues = context.Request.RouteValues;
                if (endpoint is null)
                {
                    if (context.Request.Path.Value.ToLower().Contains("/solar_api/getapiversion.cgi"))
                    {
                        var apiVersion = new ApiVersion
                        {
                            APIVersion = 1,
                            BaseURL = "/solar_api/v1/",
                            CompatibilityRange = "1.5 - 9"
                        };
                        var myDeserializedClass = JsonConvert.SerializeObject(apiVersion);
                        return context.Response.WriteAsync(myDeserializedClass);
                    }
                    //else if (context.Request.Path.Value.Contains("/solar_api/v1/GetInverterInfo.cgi"))
                    //{
                        
                    //    var inverterInfo = new InverterInfo()
                    //    {
                    //        Id = 1,
                    //        UniqueId = "INVKOSTAL",
                    //        CustomName = "CombinedKostalInverters",
                    //        DeviceType = 192,
                    //        ErrorCode = 0,
                    //        StatusCode = 7
                    //    };
                    //    return context.Response.WriteAsync(JsonConvert.SerializeObject(inverterInfo));
                    //}
                    else if (context.Request.Path.Value.Contains("/solar_api/v1/GetInverterRealtimeData.cgi"))
                    {
                        //url.addQueryItem("Scope", "Device");  //device / system
                        //url.addQueryItem("DeviceId", QString::number(deviceId));   // 0..9
                        //url.addQueryItem("DataCollection", "CumulationInverterData");   // ”CommonInverterData”
                    }
                            //return context.Response.WriteAsync(context.Request.Path + " Test");
                    //return Task.FromResult(context.Request.Path +" Test");x
                }

                //Console.WriteLine($"Endpoint: {endpoint.DisplayName}");

                //if (endpoint is RouteEndpoint routeEndpoint)
                //{
                //    Console.WriteLine("Endpoint has route pattern: " +
                //        routeEndpoint.RoutePattern.RawText);
                //}

                //foreach (var metadata in endpoint.Metadata)
                //{
                //    Console.WriteLine($"Endpoint has metadata: {metadata}");
                //}

                return next(context);
            });

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllers();
                //endpoints.MapControllerRoute(name: "solaraspx",
                // pattern: "/solar_api/v1/{action}.aspx",
                // defaults: new { controller = "SolarApi", action = "action" });
                //endpoints.MapControllerRoute(name: "solar",
                // pattern: "/solar_api/v1/{action}.cgi",
                // defaults: new { controller = "SolarApi", action = "action" });

                //endpoints.Map()

            });

        }
    }
}
