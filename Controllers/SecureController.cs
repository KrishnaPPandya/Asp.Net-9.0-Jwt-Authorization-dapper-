using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MyWebApi.Repositories;
using MyWebApi.Models;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public IActionResult AdminEndpoint()
    {
        return Ok(new { message = "Welcome, Admin!" });
    }

    [HttpGet("user")]
    [Authorize(Roles = "User")]
    public IActionResult UserEndpoint()
    {
        return Ok(new { message = "Welcome, User!" });
    }
}
