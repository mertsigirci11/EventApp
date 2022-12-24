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
    public class ContentNotificationManager : IContentNotificationService
    {
        public IContentNotificationRepository _repository;
        public ContentNotificationManager()
        {
            _repository = new ContentNotificationRepository();
        }

        public ContentNotification CreateContentNotification(ContentNotification contentNotification)
        {
            return _repository.CreateContentNotification(contentNotification);
        }

        public void DeleteContentNotification(int contentNotificationId)
        {
            _repository.DeleteContentNotification(contentNotificationId);
        }

        public List<ContentNotification> GetAllContentNotifications()
        {
            return _repository.GetAllContentNotifications();
        }

        public List<ContentNotification> GetContentNotificationById(int contentNotificationId)
        {
            return _repository.GetContentNotificationById(contentNotificationId);
        }

        public ContentNotification UpdateContentNotification(ContentNotification contentNotification)
        {
            return _repository.UpdateContentNotification(contentNotification);
        }
    }
}
