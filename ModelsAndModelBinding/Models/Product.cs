using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models;

/// <summary>
/// Represents an individual salable product
/// </summary>
public class Product
{
    /// <summary>
    /// A unique identifier for the product.
    /// The primary key of the product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// The consumer facing name of the product. May
    /// contain alphanumeric characters.
    /// </summary>
    [StringLength(20, ErrorMessage = "You can only enter a maximum of 20 characters")]
    [Required(ErrorMessage = "Please provide a product name")]
    public required string Name { get; set; }

    /// <summary>
    /// The pre-tax sales price the customer must pay.
    /// </summary>
    [Range(0.01, 10000)]
    public double Price { get; set; }

    /// <summary>
    /// The date and time the product became
    /// available for sale.
    /// </summary>
    [DataType(DataType.DateTime)]
    public DateTime StartSalesDate { get; set; }
}