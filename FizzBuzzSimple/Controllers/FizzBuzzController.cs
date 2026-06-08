using Microsoft.AspNetCore.Mvc;
using FizzBuzzSimple.Models;
using FizzBuzzSimple.Services;

namespace FizzBuzzSimple.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly IFizzBuzzService _service;

    public FizzBuzzController(IFizzBuzzService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post(FizzBuzzRequest request)
    {
        return Ok(_service.Process(request));
    }
}
