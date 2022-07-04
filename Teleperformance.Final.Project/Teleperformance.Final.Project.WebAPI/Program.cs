using Teleperformance.Final.Project.Identity;
using Teleperformance.Final.Project.Persistance;
using Teleperformance.Final.Project.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);
  
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region CONFIGURE SERVICES
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureIdentityServices(builder.Configuration);
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


#region MIDDLEWARE
//*
//Web API Exceptionlarýný burada yakalýyoruz
//*/
app.UseMiddleware<ExceptionMiddleware>();
#endregion


app.MapControllers();

app.Run();
