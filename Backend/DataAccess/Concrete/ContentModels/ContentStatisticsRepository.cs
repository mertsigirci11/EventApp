using DataAccess.Abstract.ContentModels;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ContentModels
{
    public class ContentStatisticsRepository : IContentStatisticsRepository
    {
        public MyAppDbContext _context;

        public ContentStatisticsRepository()
        {
            _context= new MyAppDbContext();
        }
        public ContentStatistics CreateContentStatistics(ContentStatistics contentStatistics)
        {
            _context.ContentStatistics.Add(contentStatistics);
            _context.SaveChanges();
            return contentStatistics;
        }

        public void DeleteContentStatistics(int contentStatisticsId)
        {
            var deletedItem = _context.ContentStatistics.Where(x=>x.Id==contentStatisticsId).FirstOrDefault();
            _context.ContentStatistics.Remove(deletedItem);
            _context.SaveChanges();
        }

        public List<ContentStatistics> GetAllContentStatistics()
        {
            return _context.ContentStatistics.ToList();
        }

        public List<ContentStatistics> GetContentStatisticsById(int contentStatisticsId)
        {
            return _context.ContentStatistics.Where(x=>x.Id== contentStatisticsId).ToList();
        }

        public ContentStatistics UpdateContentStatistics(ContentStatistics contentStatistics)
        {
            _context.ContentStatistics.Update(contentStatistics);
            _context.SaveChanges();
            return contentStatistics;
        }
    }
}
