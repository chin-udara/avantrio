namespace avantrio.app.services.contracts;

public interface IShoppingCartService
{
    Task<bool> AddItem(Guid? shoppingCart, Guid item, int quantity);
}