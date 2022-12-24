using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Friend
{
    public class Friendship
    {
        [Key]
        public int Id { get; set; }

        public int RequesterId { get; set; }

        public int ResponserId { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime ResponseDate { get; set; }

        public int Status { get; set; }

        public bool IsChecked { get; set; }

        [ForeignKey("Status")]
        public FriendshipStatus FriendshipStatus { get; set; }
    }
}
