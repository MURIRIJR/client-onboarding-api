using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Interfaces;

public interface IOnboardingService
{
    Task<IEnumerable<Onboarding>> GetAllAsync();

    Task<Onboarding?> GetByIdAsync(int id);

    Task<Onboarding> CreateAsync(Onboarding onboarding);

    Task<Onboarding?> UpdateAsync(int id, Onboarding onboarding);

    Task<bool> DeleteAsync(int id);
}