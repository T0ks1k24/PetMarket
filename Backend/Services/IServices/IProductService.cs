using Backend.Data.DTOs;

namespace Backend.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProductAsync();
        Task<IEnumerable<ProductDto>> GetProductByCategoryAsync(int categoryId);

        Task<ProductDto> GetProductByIdAsync(Guid id);
        Task AddProductAsync(ProductDto productDto);
        Task UpdateProductAsync(Guid id, ProductDto productDto);
        Task DeleteProductAsync(Guid id);
    }
}
