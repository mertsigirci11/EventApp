using Models;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.ContentModels
{
    public interface IContentRepository
    {
        public List<Content> GetAllContents();
        public List<Content> GetContentById(int contentId);
        public Content CreateContent(Content content);
        Content UpdateContent(Content content);
        public void DeleteContent(int contentId);
    }
}
