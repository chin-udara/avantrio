using avantrio.app.repositories;
using avantrio.domain.entities;
using avantrio.infrastructure.context;

namespace avantrio.infrastructure.repositories;

public class ShoppingCartRepository : IShoppingCartRepository
{

    public Task<bool> Add(Guid? _cart, Guid _product, int quantity)
    {
        if (quantity <= 0) return Task.FromResult(false);

        // get product
        var product = Context.Products.Where(p => p.Id == _product).FirstOrDefault();
        // if product does not exist
        if (product is null) return Task.FromResult(false);

        var cart = Context.Carts.Where(c => c.Id == _cart).FirstOrDefault();
        // create new cart if not already available
        cart ??= new ShoppingCart()
        {
            Id = Guid.NewGuid(),
            CreatedOn = DateTime.Now
        };

        // add to cart
        if (cart.AddProduct(product, quantity))
            return Task.FromResult(true);
        return Task.FromResult(false);
    }
}
