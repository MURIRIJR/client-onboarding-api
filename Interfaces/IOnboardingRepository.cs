using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Interfaces;

public interface IOnboardingRepository
{
    Task<IEnumerable<Onboarding>> GetAllAsync();

    Task<Onboarding?> GetByIdAsync(int id);

    Task<Onboarding> CreateAsync(Onboarding onboarding);

    Task<Onboarding?> UpdateAsync(int id, Onboarding onboarding);

    Task<bool> DeleteAsync(int id);
}