using ClientOnboardingApi.Data;
using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Repositories;
using ClientOnboardingApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPersonalRepository, PersonalRepository>();
builder.Services.AddScoped<IPersonalService, PersonalService>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAddressService, AddressService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Optional during development
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();