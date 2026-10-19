using ClientOnboardingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientOnboardingApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Personal> Personals => Set<Personal>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Onboarding> Onboardings => Set<Onboarding>();
}