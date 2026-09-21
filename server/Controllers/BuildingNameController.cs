using Microsoft.AspNetCore.Mvc;
using Solace.Interfaces;
using Solace.Models.Settlements;

namespace Solace.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BuildingNameGenerator : ControllerBase
{
    private readonly IBuildingNameGenerator _buildingNameGenerator;

    public BuildingNameGenerator(IBuildingNameGenerator buildingNameGenerator)
    {
        _buildingNameGenerator = buildingNameGenerator;
    }

    [HttpGet("tavernName")]
    public async Task<IActionResult> GenerateTavernName(int count = 1)
    {
        var result = await _buildingNameGenerator.GenerateTavernName(count);
        if (result is null)
            return BadRequest(new { error = result?.Error });

        return Ok(result.Value);
    }

    [HttpGet("patternName")]
    public async Task<IActionResult> GeneratePatternName(string category, int count = 1)
    {
        var result = await _buildingNameGenerator.GeneratePatternName(category, count);
        if (result is null)
            return BadRequest(new { error = result?.Error });

        return Ok(result.Value);
    }
}