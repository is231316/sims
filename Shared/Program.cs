using Microsoft.EntityFrameworkCore;
using Shared.DbContextFolder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/Open
// at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add DbContext as a Service
builder.Services.AddDbContext<IncidentDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("IncidentDatabase"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("IncidentDatabase"))));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
