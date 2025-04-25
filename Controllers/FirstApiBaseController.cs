using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class FirstApiBaseController : ControllerBase
{
    public string Autor { get; set; } = "Kayo Rafael";

    [HttpGet]
    [Route("HealthyGet")]
    public IActionResult Heathy()
    {
        return Ok("It's Working");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
