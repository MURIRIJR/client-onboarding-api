using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientOnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonalsController : ControllerBase
{
    private readonly IPersonalService _service;

    public PersonalsController(IPersonalService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Personal>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Personal>> Get(int id)
    {
        var personal = await _service.GetByIdAsync(id);

        if (personal == null)
        {
            return NotFound();
        }

        return Ok(personal);
    }

    [HttpPost]
    public async Task<ActionResult<Personal>> Create(Personal personal)
    {
        var created = await _service.CreateAsync(personal);

        return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Personal>> Update(int id, Personal personal)
    {
        var updated = await _service.UpdateAsync(id, personal);

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