using Business.Abstract.ContentModels;
using DataAccess.Abstract.ContentModels;
using DataAccess.Concrete.ContentModels;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.ContentModels
{
    public class ContentManager : IContentService
    {
        public IContentRepository _repository;
        public ContentManager()
        {
            _repository = new ContentRepository();
        }
        public Content CreateContent(Content content)
        {
            return _repository.CreateContent(content);
        }

        public void DeleteContent(int contentId)
        {
            _repository.DeleteContent(contentId);
        }

        public List<Content> GetAllContents()
        {
            return _repository.GetAllContents();
        }

        public List<Content> GetContentById(int contentId)
        {
            return _repository.GetContentById(contentId);
        }

        public Content UpdateContent(Content content)
        {
            return _repository.UpdateContent(content);
        }
    }
}
