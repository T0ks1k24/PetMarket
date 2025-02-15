using Backend.Data;
using Backend.Data.Models;
using Backend.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<ProductEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<ProductEntity>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Products.AsNoTracking().Where(p => p.CategoryId == categoryId).ToListAsync();
        }

        public async Task AddAsync(ProductEntity product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProductEntity product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var delProduct = await _context.Products.FindAsync(id);

            if (delProduct != null)
            {
                _context.Remove(delProduct);
                await _context.SaveChangesAsync();
            }
        }
    }
}
