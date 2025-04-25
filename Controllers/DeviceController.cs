using FirstApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

public class DeviceController : FirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = GetCustomKey();

        return Ok(key);
    }
}
