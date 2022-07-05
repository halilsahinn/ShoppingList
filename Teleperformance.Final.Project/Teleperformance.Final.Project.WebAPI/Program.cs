using Microsoft.OpenApi.Models;
using Teleperformance.Final.Project.Application;
using Teleperformance.Final.Project.Identity;
using Teleperformance.Final.Project.Persistance;
using Teleperformance.Final.Project.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region SWAGGER DOC
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
        Description = "JWT Authorization Bearer þemasý kullanýr (Example: 'Örnek 12345abcdef')",
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

#region CONFIGURE SERVICES
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureIdentityServices(builder.Configuration);
builder.Services.ConfigureApplicationServices();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

#region JWT


#endregion

#region MIDDLEWARE
//*
//Web API Exceptionlarýný burada yakalýyoruz
//*/
app.UseMiddleware<ExceptionMiddleware>();
#endregion




app.MapControllers();

app.Run();
