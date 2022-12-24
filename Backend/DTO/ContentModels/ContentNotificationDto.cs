using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ContentModels
{
    public class ContentNotificationDto
    {
        public int Id { get; set; }

        public int ContentId { get; set; }

        public int UserId { get; set; }

        public string Message { get; set; }

        public bool IsChecked { get; set; }
    }
}
