using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Services;

public class OnboardingService : IOnboardingService
{
    private readonly IOnboardingRepository _repository;

    public OnboardingService(IOnboardingRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Onboarding>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Onboarding?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Onboarding> CreateAsync(Onboarding onboarding)
    {
        return await _repository.CreateAsync(onboarding);
    }

    public async Task<Onboarding?> UpdateAsync(int id, Onboarding onboarding)
    {
        return await _repository.UpdateAsync(id, onboarding);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}