using DataAccess.Abstract.ContentModels;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ContentModels
{
    public class ContentNotificationRepository : IContentNotificationRepository
    {
        public MyAppDbContext _context;
        public ContentNotificationRepository()
        {
            _context= new MyAppDbContext();
        }

        public ContentNotification CreateContentNotification(ContentNotification contentNotification)
        {
            _context.ContentNotifications.Add(contentNotification);
            _context.SaveChanges();
            return contentNotification;
        }

        public void DeleteContentNotification(int contentNotificationId)
        {
            var deletedItem = _context.ContentNotifications.Where(x=>x.Id== contentNotificationId).FirstOrDefault();
            _context.ContentNotifications.Remove(deletedItem);
            _context.SaveChanges();
        }

        public List<ContentNotification> GetAllContentNotifications()
        {
            return _context.ContentNotifications.ToList();
        }

        public List<ContentNotification> GetContentNotificationById(int contentNotificationId)
        {
            return _context.ContentNotifications.Where(x=>x.Id== contentNotificationId).ToList();
        }

        public ContentNotification UpdateContentNotification(ContentNotification contentNotification)
        {
            _context.ContentNotifications.Update(contentNotification);
            _context.SaveChanges();
            return contentNotification;
        }
    }
}
