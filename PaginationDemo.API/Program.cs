using Microsoft.EntityFrameworkCore;
using PaginationDemo.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add database service
builder.Services.AddDbContext<EmployeeContext>(opt =>
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncetion")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseRouting();

app.MapControllers();

app.Run();
