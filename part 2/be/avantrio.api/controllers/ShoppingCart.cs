using avantrio.app.services.contracts;
using Microsoft.AspNetCore.Mvc;

namespace avantrio.api.controllers;

public class ShoppingCartController : ControllerBase
{
    private readonly IShoppingCartService _cartService;

    public ShoppingCartController(IShoppingCartService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost]
    [Route("{cart}/{item}/{quantity}")]
    public async Task<IActionResult> AddToCart(Guid? cart, Guid item, int quantity)
    {
        if (quantity > 0)
        {
            return Ok(await _cartService.AddItem(cart, item, quantity));
        }
        else
        {
            return BadRequest("Please add one or more of this item to the cart");
        }
    }
}