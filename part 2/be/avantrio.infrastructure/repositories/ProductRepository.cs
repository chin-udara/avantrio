using System.Collections.Concurrent;
using avantrio.app.repositories;
using avantrio.domain.entities;
using avantrio.infrastructure.context;

namespace avantrio.infrastructure.repositories;

public class ProductRepository : IProductRepository
{
    
    public async Task<List<Product>> Get()
    {
        return await Task.FromResult(Context.Products.ToList());
    }
}
