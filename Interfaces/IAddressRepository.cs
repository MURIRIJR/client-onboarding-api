using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Interfaces;

public interface IAddressRepository
{
    Task<IEnumerable<Address>> GetAllAsync();

    Task<Address?> GetByIdAsync(int id);

    Task<Address> CreateAsync(Address address);

    Task<Address?> UpdateAsync(int id, Address address);

    Task<bool> DeleteAsync(int id);
}