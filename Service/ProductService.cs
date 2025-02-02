using SampleWebAPI.Interface;

namespace SampleWebAPI.Service;

public class ProductService : IProductService
{
    /// <inheritdoc/>
    public List<string> GetProducts()
    {
        return new List<string>
        {
            "Product 1",
            "Product 2",
            "Product 3"
        };
    }
}
