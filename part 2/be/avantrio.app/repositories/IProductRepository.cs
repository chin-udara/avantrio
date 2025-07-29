using avantrio.domain.entities;

namespace avantrio.app.repositories;

public interface IProductRepository
{
    Task<List<Product>> Get();
}