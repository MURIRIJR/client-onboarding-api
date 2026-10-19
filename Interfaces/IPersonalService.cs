using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Interfaces;

public interface IPersonalService
{
    Task<IEnumerable<Personal>> GetAllAsync();

    Task<Personal?> GetByIdAsync(int id);

    Task<Personal> CreateAsync(Personal personal);

    Task<Personal?> UpdateAsync(int id, Personal personal);

    Task<bool> DeleteAsync(int id);
}
