using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Services;

public class PersonalService : IPersonalService
{
    private readonly IPersonalRepository _repository;

    public PersonalService(IPersonalRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Personal>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Personal?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Personal> CreateAsync(Personal personal)
    {
        return await _repository.CreateAsync(personal);
    }

    public async Task<Personal?> UpdateAsync(int id, Personal personal)
    {
        return await _repository.UpdateAsync(id, personal);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}