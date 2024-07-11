using FootBallBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICommentService
    {
        Task<List<CommentViewModel>> GetAllByArticleId(int id);
        Task Add(CommentViewModel model);
    }
}