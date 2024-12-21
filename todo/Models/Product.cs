using System.ComponentModel.DataAnnotations;

namespace Models;

public class Product
{
    [Key]   
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
