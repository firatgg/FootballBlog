using Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCUI.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = await _categoryService.GetAll();
            return View(list);
        }
    }
}
