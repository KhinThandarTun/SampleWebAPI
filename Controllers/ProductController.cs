using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPI.Controllers;

/// <summary>
/// Controller to manage product-related operations.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    /// <summary>
    /// Gets all products.
    /// </summary>
    /// <returns>A list of all products.</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Get all products");
    }
}
