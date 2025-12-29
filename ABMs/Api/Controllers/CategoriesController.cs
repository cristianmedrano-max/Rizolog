using Microsoft.AspNetCore.Mvc;
using Rizolog.Application.ABMs.Interfaces;

namespace Rizolog.Api.ABMs.Controllers;

[ApiController]
[Route("api/abms/categories")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateCategoryRequest request)
    {
        var category = _service.Create(request.Name);

        return Ok(new
        {
            category.Id,
            category.Name
        });
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("ABMS OK");
    }
}

public record CreateCategoryRequest(string Name);
