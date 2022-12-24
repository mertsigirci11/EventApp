using DataAccess.Abstract.ContentModels;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ContentModels
{
    public class ContentRepository : IContentRepository
    {
        public MyAppDbContext _context;

        public ContentRepository()
        {
            _context= new MyAppDbContext();
        }

        public Content CreateContent(Content content)
        {
            _context.Contents.Add(content);
            _context.SaveChanges();
            return content;
        }

        public void DeleteContent(int contentId)
        {
            var deletedItem = _context.Contents.Where(x=>x.Id==contentId).FirstOrDefault();
            _context.Contents.Remove(deletedItem);
            _context.SaveChanges();
        }

        public List<Content> GetAllContents()
        {
            return _context.Contents.ToList();
        }

        public List<Content> GetContentById(int contentId)
        {
            return _context.Contents.Where(x=>x.Id==contentId).ToList();
        }

        public Content UpdateContent(Content content)
        {
            _context.Contents.Update(content);
            _context.SaveChanges();
            return content;
        }
    }
}
