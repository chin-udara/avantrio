namespace avantrio.app.repositories;

public interface IShoppingCartRepository
{
    Task<bool> Add(Guid? cart, Guid product, int quantity);
}