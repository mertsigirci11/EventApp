using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ContentModels
{
    public class ContentNotification
    {
        [Key]
        public int Id { get; set; }

        public int ContentId { get; set; }

        public int UserId { get; set; }

        public string Message { get; set; }

        public bool IsChecked { get; set; }

        [ForeignKey("ContentId")]
        public Content Content { get; set; }
    }
}
