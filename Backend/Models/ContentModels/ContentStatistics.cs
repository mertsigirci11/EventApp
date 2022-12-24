using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ContentModels
{
    public class ContentStatistics
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ContentId { get; set; }

        public bool IsLiked { get; set; }

        public bool IsShared { get; set; }

        public bool IsComment { get; set; }

        public string? Comment { get; set; }

        public int ParticipantId { get; set; }

        [ForeignKey("ContentId")]
        public Content Content { get; set; }
    }
}
