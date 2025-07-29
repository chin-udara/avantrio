using System.Reflection.Metadata.Ecma335;

namespace avantrio.domain.entities;

public class ShoppingCart
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public List<Product> Products { get; set; } = [];

    // TODO: do we really the customer?
    public Guid Customer { get; set; }

    public virtual Customer CustomerNavigation { get; set; } = null!;

    public bool AddProduct(Product product, int quantity)
    {
        if (product.AvailableQuantity > quantity && quantity > 0)
            Products.Add(product);
        else return false;
        return true;
    }
}