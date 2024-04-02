using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DotnetElkSample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LogsController : ControllerBase
{

    [HttpGet]
    [Route("Information")]
    public IActionResult Information()
    {
        Log.Information("Information log");
        return Ok();
    }

    [HttpGet]
    [Route("Warning")]
    public IActionResult Warning()
    {
        Log.Warning("Warning log");
        return Ok();
    }

    [HttpGet]
    [Route("Error")]
    public IActionResult Error()
    {
        Log.Error("Error log");
        return Ok();
    }

    [HttpGet]
    [Route("Fatal")]
    public IActionResult Fatal()
    {
        Log.Fatal("Fatal log");
        return Ok();
    }
}
