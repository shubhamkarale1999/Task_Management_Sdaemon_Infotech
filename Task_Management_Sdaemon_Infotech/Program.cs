using Microsoft.EntityFrameworkCore;
using Task_Management_Sdaemon_Infotech.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaskManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagementContext") ?? throw new InvalidOperationException("Connection string 'TaskManagementContext' not found.")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
