using Microsoft.AspNetCore.Mvc;

namespace OtakuLog.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet(Name = "HelloWorld")]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}
