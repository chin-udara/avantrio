using avantrio.app.repositories;
using avantrio.app.services.contracts;
using avantrio.domain.entities;

namespace avantrio.app.services.implementations;

public class ProductsService(IProductRepository productRepo) : IProductsService
{
    private readonly IProductRepository _productRepo = productRepo;

    public async Task<List<Product>> GetAllAvailableProducts()
    {
        return await _productRepo.Get();
    }
}