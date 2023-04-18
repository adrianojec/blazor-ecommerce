﻿global using BlazorECommerce.Server.Commands.Products;
global using BlazorECommerce.Server.Commands.Products.Interfaces;
global using BlazorECommerce.Server.Data;
global using BlazorECommerce.Shared.Core;
global using BlazorECommerce.Shared.Models;
global using Microsoft.EntityFrameworkCore;

using BlazorECommerce.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database Connection
builder.Services.AddDbContext<DataContext>(opt =>
{
   opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCommandServices();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseWebAssemblyDebugging();
}
else
{
   app.UseExceptionHandler("/Error");
   // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

