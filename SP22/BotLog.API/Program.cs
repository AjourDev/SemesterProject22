﻿using Microsoft.EntityFrameworkCore;
using BotLog.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var localKey = "Data Source=localhost,1433;Database=master;Integrated Security=False;User Id=sa;Password=someRandomPa$$w0rd;";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(localKey));
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

