using FootBallBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

    }
}
