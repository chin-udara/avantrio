using avantrio.domain.entities;

namespace avantrio.app.services.contracts;

public interface IProductsService
{
    Task<List<Product>> GetAllAvailableProducts();
}