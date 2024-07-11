using AutoMapper;
using Entity.Entities;
using Entity.Services;
using Entity.UnitOfWorks;
using FootBallBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task Add(ArticleViewModel model)
        {
            await _uow.GetRepository<Article>().Add(_mapper.Map<Article>(model));
            await _uow.CommitAsync();	//SaveChangesAsync();
        }

        public async Task<ArticleViewModel> Get(int id)
        {
            var article = await _uow.GetRepository<Article>().GetByIdAsync(id);
            return _mapper.Map<ArticleViewModel>(article);
        }

        public async Task<IEnumerable<ArticleViewModel>> GetAll()
        {
            //_uow.GetRepository<Article>() -> Repository<Article> karşılık gelir.
            var list = await _uow.GetRepository<Article>().GetAllAsync();

            return _mapper.Map<List<ArticleViewModel>>(list);
        }
    }
}
