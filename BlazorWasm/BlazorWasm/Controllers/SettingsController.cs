using BlazorWasm.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SettingsController : ControllerBase
{
    [HttpGet("user")]
    public AuthorizedUser GetUser()
    {
        return new AuthorizedUser();

        // User signed in:
        //return new AuthorizedUser { Name = "UserName" };
    }
}
