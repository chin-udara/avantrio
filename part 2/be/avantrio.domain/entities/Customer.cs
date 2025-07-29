namespace avantrio.domain.entities;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string ContactNumber { get; set; } = null!;
    public string EmailAddress { get; set; } = null!;
}