using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OtakuLog.Api.Controllers;

[ApiController]
[Route("api")]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("hello")]
    public IActionResult Get()
    {
        return Ok("hello");
    }
}
