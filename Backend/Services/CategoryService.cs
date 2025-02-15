
using Backend.Data.DTOs;
using Backend.Data.Models;
using Backend.Repository.IRepository;
using Backend.Services.IServices;

namespace Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }



        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _repository.GetAllAsync();
            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }

        public async Task<CategoryDto?> GetCategoryByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null) return null;

            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public async Task AddCategoryAsync(CategoryDto categoryDto)
        {
            var category = new CategoryEntity
            {
                Name = categoryDto.Name
            };

            await _repository.AddAsync(category);
        }

        public async Task UpdateCategoryAsync(int id, CategoryDto categoryDto)
        {
            var existingCategory = await _repository.GetByIdAsync(id);
            if (existingCategory == null) return;

            existingCategory.Name = categoryDto.Name;
            await _repository.UpdateAsync(existingCategory);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

    }
}
