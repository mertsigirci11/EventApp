using Models;
using Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.ContentModels
{
    public interface IContentNotificationService
    {
        public List<ContentNotification> GetAllContentNotifications();
        public List<ContentNotification> GetContentNotificationById(int contentNotificationId);
        public ContentNotification CreateContentNotification(ContentNotification contentNotification);
        ContentNotification UpdateContentNotification(ContentNotification contentNotification);
        public void DeleteContentNotification(int contentNotificationId);
    }
}
