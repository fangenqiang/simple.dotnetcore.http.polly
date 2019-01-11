using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using simple.dotnetcore.api.HttpClientFactory;
using simple.dotnetcore.http.Extensions;
using Swashbuckle.AspNetCore.Swagger;

namespace simple.dotnetcore.api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // 注册 HTTP 客户端


            services.AddTransient<IHttpClientService, HttpClientService>();
            services.AddHttpClients(Configuration);

            services.AddHttpClient();

            #region Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Title = "simple.dotnetcore.api",
                    Version = "v1",
                    Description = "simple.dotnetcore.api",
                });
                options.DocInclusionPredicate((docName, description) => true);
                options.IncludeXmlComments(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simple.dotnetcore.api.xml"), true);
                //options.OperationFilter<AuthTokenHeader>();
                //添加header验证信息
                var security = new Dictionary<string, IEnumerable<string>> { { "simple.dotnetcore.api", new string[] { } }, };
                options.AddSecurityRequirement(security);
                options.AddSecurityDefinition("simple.dotnetcore.api", new ApiKeyScheme
                {
                    Description = "token授权(数据将在请求头中进行传输) 直接在下框中输入{token}",
                    Name = "Authorization",//参数名称
                    In = "header",//存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "simple.dotnetcore.api V1");
                options.InjectJavascript("/swaggeruiconfig/swaggerlan.js");
            });
        }
    }
}
