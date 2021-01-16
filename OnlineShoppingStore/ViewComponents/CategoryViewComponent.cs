using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingStore.Data;
using OnlineShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingStore.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public CategoryViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetCategoriesAsync();
            return View(items);
        }

        private async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
