using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using toDoList;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string mysqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddDbContextPool<ApplicationDb>(options =>
{
    options.UseMySql(mysqlConnection, ServerVersion.AutoDetect(mysqlConnection));
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseAuthorization();

app.MapControllers();

app.Run();