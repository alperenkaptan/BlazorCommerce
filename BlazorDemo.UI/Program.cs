using BlazorDemo.Domain.DataAccess;
using BlazorDemo.Domain.Models;
using BlazorDemo.Repository.Interfaces;
using BlazorDemo.Repository.Repositories;
using BlazorDemo.Service.Interfaces;
using BlazorDemo.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
var ConnectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<BlazorDemoContext>(options => options.UseSqlServer(ConnectionString));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICustomeService<Customer>, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
