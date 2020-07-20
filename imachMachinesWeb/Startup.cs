using imachMachinesWeb.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace imachMachinesWeb
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
            services.AddRazorPages()            
                    .AddRazorRuntimeCompilation();

            services.AddSingleton<MockExtruder>();
            services.AddSingleton<MockCrosshead>();
            services.AddSingleton<MockFlyerPo>();
            services.AddSingleton<MockCoolingThrough>();
            services.AddSingleton<MockSpoolerPo>();
            services.AddSingleton<MockSpoolerTu>();
            services.AddSingleton<MockDoubleSpoolerTu>();
            services.AddSingleton<MockForkTypePo>();
            services.AddSingleton<MockForkTypeTu>();
            services.AddSingleton<MockPortalTypePo>();
            services.AddSingleton<MockPortalTypeTu>();
            services.AddSingleton<MockDiscCapstan>();
            services.AddSingleton<MockCaterpillarCapstan>();
            services.AddSingleton<MockRotatingCaterpillarCapstan>();
            services.AddSingleton<MockMultiWirePo>();
            services.AddSingleton<MockPairingPo>();
            services.AddSingleton<MockDoubleTwistBuncher>();
            services.AddSingleton<MockSingleTwistBuncher>();
            services.AddSingleton<MockPlanetaryStrander>();
            services.AddSingleton<MockRotatingPo>();
            services.AddSingleton<MockRotatingTu>();
            services.AddSingleton<MockRigidStrander>();
            services.AddSingleton<MockRigidArmoring>();
            services.AddSingleton<MockSkipStrander>();
            services.AddSingleton<MockTapingHead>();
            services.AddSingleton<MockWoodenReelCoiler>();
            services.AddSingleton<MockAutomaticCoiler>();
            services.AddSingleton<MockSemiAutomaticCoiler>();
            services.AddSingleton<MockDancer>();
            services.AddSingleton<MockGranuleMachine>();
            services.AddSingleton<MockCompactingHead>();
            services.AddSingleton<MockLengthMeasure>();
            services.AddSingleton<MockPowderingDevice>();
            services.AddSingleton<MockReel>();
            services.AddSingleton<MockTapePo>();
            services.AddSingleton<MockSparePart>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var provider = new FileExtensionContentTypeProvider();
            // Add new mappings
            provider.Mappings[".myapp"] = "application/x-msdownload";

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")),
                RequestPath = "/StaticContentDir",
                ContentTypeProvider = provider
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
