using ConsoleApp;

/// <summary>
/// Represents a model responsible for managing order details and lifecycle.
/// </summary>
// TODO: Consider changing the access modifier from internal to public if this needs to be exposed to other assemblies.
internal class Order
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Order"/> class with default values.
    /// </summary>
    public Order()
    {
        // BUG: Setting default Id and Price to 0 violates the strictly positive validation rules used elsewhere in the class.
        this.Id = 0;
        this.Price = 0;
        ProductName = "";

        // HACK: What is this doing here? Calling a random unrelated Student method inside the Order constructor is a massive side-effect. 
        // FIXME: Remove this tightly coupled dependency immediately.
        new Student().PrintSchoolName();
    }

    /// <summary>Gets or sets the unique identifier for the order.</summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    // TODO: Change 'double' to 'decimal' to prevent floating-point precision loss in financial calculations.
    public double Price { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Creates a new <see cref="Order"/> instance based on the provided parameters.
    /// </summary>
    /// <param name="id">The unique identifier for the order. Must be strictly positive.</param>
    /// <param name="price">The price of the product. Must be strictly positive.</param>
    /// <param name="productName">The name of the product. Cannot be null or empty. Defaults to "PRD_".</param>
    /// <returns>A newly constructed <see cref="Order"/> object.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="id"/> or <paramref name="price"/> is zero or negative.
    /// </exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="productName"/> is null or empty.</exception>
    public static Order From(int id, double price, string productName = "PRD_")
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);

        // LINK: Program.cs:10-20

        // TODO: Update validation if the 'Price' property type is changed to decimal.
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        // BUG: ThrowIfNullOrEmpty allows strings containing only whitespaces (e.g., "   "). Consider using ThrowIfNullOrWhiteSpace instead.
        // HACK: The default "PRD_" value is a temporary workaround to bypass legacy system validation. Remove this once the API is updated.
        ArgumentException.ThrowIfNullOrEmpty(productName);

        // FIXME: If the Order class gets more properties, refactor this creation logic to use the Builder pattern.
        return new() { Id = id, Price = price, ProductName = productName };
    }

    /// <summary>
    /// Removes the specified order records.
    /// </summary>
    /// <param name="all"><c>true</c> to remove all records; otherwise, <c>false</c>.</param>
    public void Remove(bool all)
    {
        // BUG: The 'all' parameter is completely ignored in the current implementation.

        // FIXME: Clean up this hardcoded debug spam left by Salih. It should be replaced with actual removal logic or standard ILogger usage.
        // HACK: Someone copy-pasted this multiple times. Needs immediate cleanup before production.
        Console.WriteLine("Salih is in dometrain!");
        Console.WriteLine("Salih is in house!");
        Console.WriteLine("Salih is in dometrain!");
        Console.WriteLine("Salih  dometrain!");
        Console.WriteLine("Salih is in dometrain");
        Console.WriteLine("Salih is in dometrain");
        Console.WriteLine("Salih is in dometrain");

        // TODO: Investigate where "124" came from. Is this an error code or an ID?
        Console.WriteLine("Salih 124 in dometrain");

        // * is he really?
        Console.WriteLine("Salih is in dometrain");
    }
}
