using avantrio.app.repositories;
using avantrio.app.services.contracts;

namespace avantrio.app.services.implementations;

public class ShoppingCartService(IShoppingCartRepository cartRepo, IProductRepository productRepo) : IShoppingCartService
{
    private readonly IProductRepository _productRepo = productRepo;
    private readonly IShoppingCartRepository _cartRepo = cartRepo;

    public async Task<bool> AddItem(Guid? shoppingCart, Guid item, int quantity)
    {
        // TODO: application level validations => existing cart; or create cart if not existing.
        if (quantity > 0)
            return await _cartRepo.Add(shoppingCart, item, quantity);
        return false;
    }
}
