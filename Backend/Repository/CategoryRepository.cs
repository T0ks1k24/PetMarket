using Backend.Data;
using Backend.Data.Models;
using Backend.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryEntity>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<CategoryEntity?> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task AddAsync(CategoryEntity category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CategoryEntity category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var delCategory = await _context.Categories.FindAsync(id);

            if (delCategory != null)
            {
                _context.Remove(delCategory);
                await _context.SaveChangesAsync();
            }
        }

    }
}
