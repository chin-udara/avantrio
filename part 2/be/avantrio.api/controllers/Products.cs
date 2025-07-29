using avantrio.app.services.contracts;
using Microsoft.AspNetCore.Mvc;

namespace avantrio.api.controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return  Ok(await _productsService.GetAllAvailableProducts());
    }
}