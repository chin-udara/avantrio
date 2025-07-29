using System.Collections.Concurrent;
using avantrio.domain.entities;

namespace avantrio.infrastructure.context;

public class Context
{
    public static readonly ConcurrentBag<Product> Products =
    [
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Laptop",
            Price = 1500,
            AvailableQuantity = 10
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Headphones",
            Price = 200,
            AvailableQuantity = 5
        }
    ];

    public static readonly ConcurrentBag<ShoppingCart> Carts = [];
}