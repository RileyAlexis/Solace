using Microsoft.AspNetCore.Mvc;
using Solace.Interfaces;

namespace Solace.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarkovNameGenerator : ControllerBase
{
    private readonly IMarkovNameGenerator _markovNameGenerator;

    public MarkovNameGenerator(IMarkovNameGenerator markovNameGenerator)
    {
        _markovNameGenerator = markovNameGenerator;
    }

    [HttpGet("generateName")]
    public async Task<IActionResult> GenerateName(int count = 1)
    {
        var result = await _markovNameGenerator.GenerateName(count);
        if (result is null)
            return BadRequest(new { error = result?.Error });

        return Ok(result.Value);
    }

    [HttpGet("generateCityName")]
    public async Task<IActionResult> GenerateCityName(int count = 1)
    {
        var result = await _markovNameGenerator.GenerateCityName(count);
        if (result is null)
            return BadRequest(new { error = result?.Error });

        return Ok(result.Value);
    }
}