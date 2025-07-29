namespace avantrio.domain.entities;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }
    
    public int AvailableQuantity { get; set; }
}