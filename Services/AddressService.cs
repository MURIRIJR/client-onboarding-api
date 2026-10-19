using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Services;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _repository;

    public AddressService(IAddressRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Address>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Address?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Address> CreateAsync(Address address)
    {
        return await _repository.CreateAsync(address);
    }

    public async Task<Address?> UpdateAsync(int id, Address address)
    {
        return await _repository.UpdateAsync(id, address);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}