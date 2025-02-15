using Backend.Data.DTOs;
using Backend.Data.Models;
using Backend.Repository.IRepository;
using Backend.Services.IServices;

namespace Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetProductAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                CategoryId = p.CategoryId
            }).ToList();
        }

        public async Task<ProductDto> GetProductByIdAsync(Guid id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                throw new KeyNotFoundException("Product not found");

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId
            };
        }

        public async Task<IEnumerable<ProductDto>> GetProductByCategoryAsync(int categoryId)
        {
            var products = await _repository.GetByCategoryAsync(categoryId);
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                CategoryId = p.CategoryId
            }).ToList();
        }

        public async Task AddProductAsync(ProductDto productDto)
        {
            var product = new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                ImageUrl = productDto.ImageUrl,
                CategoryId = productDto.CategoryId
            };

            await _repository.AddAsync(product);
        }

        public async Task DeleteProductAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task UpdateProductAsync(Guid id, ProductDto productDto)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                throw new KeyNotFoundException("Product not found");

            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Price = productDto.Price;
            product.ImageUrl = productDto.ImageUrl;
            product.CategoryId = productDto.CategoryId;

            await _repository.UpdateAsync(product);
        }
    }
}
