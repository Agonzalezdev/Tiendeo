using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiendeo.API.Config
{
    public static class SwaggerConfig
    {
        private const string SWAGGER_VERSION = "v1.0";
        private const string SWAGGER_NAME = "TIENDEO";
        private const string SWAGGER_TITLE = "TIENDEO API DEMO DOCUMENTATION";

        public static void Setup(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(SWAGGER_NAME, new Info { Title = SWAGGER_TITLE, Version = SWAGGER_VERSION });
            });
        }

        public static void Init(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/" + SWAGGER_NAME + "/swagger.json", SWAGGER_TITLE);
                c.InjectJavascript("/Swagger/jquery-2.1.4.min.js");
                c.InjectJavascript("/Swagger/SwaggerUiCustomization.js");
            });
        }
    }
}
