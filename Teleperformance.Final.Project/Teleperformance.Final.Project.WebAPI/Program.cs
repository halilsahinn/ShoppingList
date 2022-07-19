using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Teleperformance.Final.Project.Application;
using Teleperformance.Final.Project.Application.Contracts.RabbitMq;
using Teleperformance.Final.Project.Caching;
using Teleperformance.Final.Project.Identity;
using Teleperformance.Final.Project.MessageBroker.RabbitMq;
using Teleperformance.Final.Project.Persistance;
using Teleperformance.Final.Project.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(opt =>
{

    opt.RespectBrowserAcceptHeader = true;

});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers()
        .AddNewtonsoftJson();
builder.Services.AddTransient<IRabbitMqService, RabbitMqManager>();

#region API VERSIONING
builder.Services.AddApiVersioning(_ =>
{
    _.DefaultApiVersion = new ApiVersion(1, 0);
    _.AssumeDefaultVersionWhenUnspecified = true;
    _.ReportApiVersions = true;
});
#endregion

#region SWAGGER & SWAGGER DOC CONFIGURATION
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new OpenApiInfo
    {

        Version = "v1",
        Title = "Teleformans Final Projesi",
        Description = "Asp.net Core Web API, Clean Architecture,CQRS, Media Pattern Kullanýlarak Bir Web API Projesi Geliþtirilecektir..",
        Contact = new OpenApiContact
        {
            Name = "Halil ÞAHÝN",
            Email = "halil.ibrahim.sahin@hotmail.com",
            Url = new Uri("https://www.linkedin.com/in/halilibrahimsahin/")
        },
        License = new OpenApiLicense
        {
            Name = "MIT",
            Url = new Uri("https://opensource.org/licenses/MIT")
        }

    });

    s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization Bearer þemasý kullanýr (Örnek: 'bearer 12345abcdef')",
        Name = "Authorization - Kimlik Kontrolü",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    s.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });

});

#endregion

#region CONFIGURE SERVICES: Katmanlardaki Middleware'lerin projeye Dahil Edilmesi
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureIdentityServices(builder.Configuration);
builder.Services.ConfigureCacheServices(builder.Configuration);
builder.Services.ConfigureApplicationServices();
#endregion

#region CORS: Projenin Dýþarýya Açýlmasý

builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
#endregion

var app = builder.Build();

#region DEVELOPMENT VE PRODUCTION KONTROLU
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

#region AUTHENTICATION  & AUTHORIZATION
app.UseAuthentication();
app.UseAuthorization();
#endregion


app.UseHttpsRedirection();

#region USE CORS
app.UseCors("CorsPolicy");
#endregion


#region CUSTOM MIDDLEWARE - > EXCEPTION
//*
//Web API Exceptionlarýný burada yakalýyoruz
//*/
app.UseMiddleware<ExceptionMiddleware>();
#endregion

app.MapControllers();

app.Run();
