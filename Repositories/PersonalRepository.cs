using ClientOnboardingApi.Data;
using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientOnboardingApi.Repositories;

public class PersonalRepository : IPersonalRepository
{
    private readonly AppDbContext _context;

    public PersonalRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Personal>> GetAllAsync()
    {
        return await _context.Personals.ToListAsync();
    }

    public async Task<Personal?> GetByIdAsync(int id)
    {
        return await _context.Personals.FindAsync(id);
    }

    public async Task<Personal> CreateAsync(Personal personal)
    {
        _context.Personals.Add(personal);

        await _context.SaveChangesAsync();

        return personal;
    }

    public async Task<Personal?> UpdateAsync(int id, Personal personal)
    {
        var existing = await _context.Personals.FindAsync(id);

        if (existing == null)
        {
            return null;
        }

        existing.Title = personal.Title;
        existing.FirstName = personal.FirstName;
        existing.MiddleName = personal.MiddleName;
        existing.LastName = personal.LastName;
        existing.DateOfBirth = personal.DateOfBirth;
        existing.Gender = personal.Gender;
        existing.MaritalStatus = personal.MaritalStatus;
        existing.Nationality = personal.Nationality;
        existing.IdType = personal.IdType;
        existing.IdNumber = personal.IdNumber;
        existing.Email = personal.Email;
        existing.MobileNumber = personal.MobileNumber;
        existing.Occupation = personal.Occupation;
        existing.EmploymentStatus = personal.EmploymentStatus;

        await _context.SaveChangesAsync();

        return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var personal = await _context.Personals.FindAsync(id);

        if (personal == null)
        {
            return false;
        }

        _context.Personals.Remove(personal);

        await _context.SaveChangesAsync();

        return true;
    }
}