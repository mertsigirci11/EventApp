using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.ContentModels
{
    public interface IContentStatisticsRepository
    {
        public List<ContentStatistics> GetAllContentStatistics();
        public List<ContentStatistics> GetContentStatisticsById(int contentStatisticsId);
        public ContentStatistics CreateContentStatistics(ContentStatistics contentStatistics);
        ContentStatistics UpdateContentStatistics(ContentStatistics contentStatistics);
        public void DeleteContentStatistics(int contentStatisticsId);
    }
}
