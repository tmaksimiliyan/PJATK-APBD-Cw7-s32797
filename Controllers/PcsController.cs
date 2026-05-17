using Cwiczenia7.DTOs;
using Cwiczenia7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia7.Controllers;

[ApiController]
[Route("api/pcs")]
public class PcsController : ControllerBase
{
    private readonly IPcService _pcService;

    public PcsController(IPcService pcService)
    {
        _pcService = pcService;
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<PcDto>>> GetAllAsync()
    {
        var pcs = await _pcService.GetAllAsync();

        return Ok(pcs);
    }

    [HttpGet("{id:int}/components")]
    public async Task<ActionResult<PcWithComponentsDto>> GetByIdWithComponentsAsync(int id)
    {
        var pc = await _pcService.GetByIdWithComponentsAsync(id);

        if (pc is null)
        {
            return NotFound();
        }

        return Ok(pc);
    }

    [HttpPost]
    public async Task<ActionResult<PcDto>> CreateAsync(CreatePcDto request)
    {
        var createdPc = await _pcService.CreateAsync(request);

        return CreatedAtAction(
            nameof(GetByIdWithComponentsAsync),
            new { id = createdPc.Id },
            createdPc
        );
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<PcDto>> UpdateAsync(int id, UpdatePcDto request)
    {
        var updatedPc = await _pcService.UpdateAsync(id, request);

        if (updatedPc is null)
        {
            return NotFound();
        }

        return Ok(updatedPc);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var deleted = await _pcService.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}