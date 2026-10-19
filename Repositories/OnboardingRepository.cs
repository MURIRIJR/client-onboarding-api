using ClientOnboardingApi.Data;
using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientOnboardingApi.Repositories;

public class OnboardingRepository : IOnboardingRepository
{
    private readonly AppDbContext _context;

    public OnboardingRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Onboarding>> GetAllAsync()
    {
        return await _context.Onboardings.ToListAsync();
    }

    public async Task<Onboarding?> GetByIdAsync(int id)
    {
        return await _context.Onboardings.FindAsync(id);
    }

    public async Task<Onboarding> CreateAsync(Onboarding onboarding)
    {
        _context.Onboardings.Add(onboarding);

        await _context.SaveChangesAsync();

        return onboarding;
    }

    public async Task<Onboarding?> UpdateAsync(int id, Onboarding onboarding)
    {
        var existing = await _context.Onboardings.FindAsync(id);

        if (existing == null)
        {
            return null;
        }

        existing.PersonalId = onboarding.PersonalId;
        existing.Status = onboarding.Status;
        existing.CurrentStep = onboarding.CurrentStep;
        existing.SubmittedAt = onboarding.SubmittedAt;

        await _context.SaveChangesAsync();

        return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var onboarding = await _context.Onboardings.FindAsync(id);

        if (onboarding == null)
        {
            return false;
        }

        _context.Onboardings.Remove(onboarding);

        await _context.SaveChangesAsync();

        return true;
    }
}