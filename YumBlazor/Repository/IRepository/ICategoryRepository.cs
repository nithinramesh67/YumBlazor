﻿using YumBlazor.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace YumBlazor.Repository.IRepository
{
	public interface ICategoryRepository
	{
		public Task<Category> CreateAsync(Category obj);
		public Task<Category> UpdateAsync(Category obj);
		public Task<bool> DeleteAsync(int id);
		public Task<Category> GetAsync(int id);
		public Task<IEnumerable<Category>> GetAllAsync();
	}
}
