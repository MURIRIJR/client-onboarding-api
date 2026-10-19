using ClientOnboardingApi.Interfaces;
using ClientOnboardingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientOnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OnboardingsController : ControllerBase
{
    private readonly IOnboardingService _service;

    public OnboardingsController(IOnboardingService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Onboarding>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Onboarding>> Get(int id)
    {
        var onboarding = await _service.GetByIdAsync(id);

        if (onboarding == null)
        {
            return NotFound();
        }

        return Ok(onboarding);
    }

    [HttpPost]
    public async Task<ActionResult<Onboarding>> Create(Onboarding onboarding)
    {
        var created = await _service.CreateAsync(onboarding);

        return CreatedAtAction(
            nameof(Get),
            new { id = created.Id },
            created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Onboarding>> Update(int id, Onboarding onboarding)
    {
        var updated = await _service.UpdateAsync(id, onboarding);

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