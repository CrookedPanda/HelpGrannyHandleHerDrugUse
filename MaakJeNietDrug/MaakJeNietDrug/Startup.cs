using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.Handlers.MedicineHandlers;
using MaakJeNietDrugLogic.Handlers.AccountHandlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MaakJeNietDrugLogic;
using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using Microsoft.EntityFrameworkCore.Design;

namespace MaakJeNietDrug
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
            services.AddControllers();
            // todo: uncomment to use MySQL
            //services.AddDbContextPool<DataBaseContext>(
            //    options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")
            //));

            DataBaseSeeder.SeedMedicine();

            services.AddScoped<IGetMedicinesHandler, GetMedicinesHandler>();
            services.AddScoped<IAddMedicineHandler, AddMedicineHandler>();
            services.AddScoped<IDeleteMedicineHandler, DeleteMedicineHandler>();
            services.AddScoped<IPutMedicineHandler, PutMedicineHandler>();

            services.AddScoped<IGetAccountHandler, GetAccountHandler>();
            services.AddScoped<IAddAccountHandler, AddAccountHandler>();
            services.AddScoped<IDeleteAccountHandler, DeleteAccountHandler>();
            services.AddScoped<IPutAccountHandler, PutAccountHandler>();
            services.AddSpaStaticFiles(options => options.RootPath = "drug-frontend/dist");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });           
        }
    }
}
