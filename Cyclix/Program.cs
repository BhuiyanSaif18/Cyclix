using Cyclix.Contracts;
using Cyclix.DAL;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Cyclix.MappingProfile;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ICycleBrandRepository, CycleBrandRepository>();
builder.Services.AddScoped<ICycleTypeRepository, CycleTypeRepository>();
builder.Services.AddScoped<IRepairRequestRepository, RepairRequestRepository>();
builder.Services.AddAutoMapper(typeof(RepairRequestMappingProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
