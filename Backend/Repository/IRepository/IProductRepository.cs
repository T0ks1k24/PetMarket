using Backend.Data.Models;

namespace Backend.Repository.IRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<ProductEntity>> GetByCategoryAsync(int categoryId);
        Task AddAsync(ProductEntity product);
        Task UpdateAsync(ProductEntity product);
        Task DeleteAsync(Guid id);
    }
}
