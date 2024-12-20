using Grpc.Core;
using System.Threading.Tasks;

public class ProductServiceImpl : ProductService.ProductServiceBase
{
    public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ProductResponse
        {
            ProductDetails = $"Details for Product ID: {request.ProductId}"
        });
    }
}

