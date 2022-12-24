using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.ContentModels
{
    public interface IContentService
    {
        public List<Content> GetAllContents();
        public List<Content> GetContentById(int contentId);
        public Content CreateContent(Content content);
        Content UpdateContent(Content content);
        public void DeleteContent(int contentId);
    }
}
