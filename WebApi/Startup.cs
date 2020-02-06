using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore.Application.Systems.Sys001s;
using AppCore.Data.EF;
using AppCore.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace WebApi
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
          
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("AppDbConnection")));
            services.AddControllers();
            //  services.AddMvc();
            services.AddCors(o => o.AddPolicy("AppCoreCorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            //  services.AddAutoMapper();
            // services.AddSingleton(Mapper.Configuration);
            //   services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));
            //  services.AddMvc()
            //      .AddViewLocalization()
            //     .AddDataAnnotationsLocalization();
            // .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddScoped<ISys001Service,Sys001Service>();//Dịch vụ trọn đời có phạm vi được tạo một lần cho mỗi yêu cầu trong phạm vi. Nó tương đương với Singleton trong phạm vi hiện tại. ví dụ. trong MVC nó tạo 1 thể hiện cho mỗi yêu cầu http nhưng sử dụng cùng một thể hiện trong các cuộc gọi khác trong cùng một yêu cầu web
          //  services.AddSingleton<ISys001Service,Sys001Service>(); //Tạo một thể hiện duy nhất trong suốt ứng dụng. Nó tạo ra thể hiện lần đầu tiên và sử dụng lại cùng một đối tượng trong tất cả các cuộc gọi
          //  services.AddTransient<ISys001Service, Sys001Service>();//Dịch vụ trọn đời thoáng qua được tạo ra mỗi khi chúng được yêu cầu. Cuộc đời này hoạt động tốt nhất cho các dịch vụ nhẹ, không trạng thái
            services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddScoped(typeof(IRepository<,>), typeof(EFRepository<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
              
            }
            //else
            //{
            //   app.UseExceptionHandler("/home/error");
            //}

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AppCoreCorsPolicy");
            //  app.UseAuthorization();
            //app.UseCookiePolicy();
            app.UseAuthentication();
           
          //  app.UseSwagger();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
