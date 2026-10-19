using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientOnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressesController : ControllerBase
{
    private readonly IAddressService _service;

    public AddressesController(IAddressService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Address>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Address>> Get(int id)
    {
        var address = await _service.GetByIdAsync(id);

        if (address == null)
        {
            return NotFound();
        }

        return Ok(address);
    }

    [HttpPost]
    public async Task<ActionResult<Address>> Create(Address address)
    {
        var created = await _service.CreateAsync(address);

        return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Address>> Update(int id, Address address)
    {
        var updated = await _service.UpdateAsync(id, address);

        if (updated == null)
        {
            return NotFound();
        }

        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}