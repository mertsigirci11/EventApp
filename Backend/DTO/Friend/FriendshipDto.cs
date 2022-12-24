using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Friend
{
    public class FriendshipDto
    {
        public int Id { get; set; }

        public int RequesterId { get; set; }

        public int ResponserId { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime ResponseDate { get; set; }

        public int Status { get; set; }

        public bool IsChecked { get; set; }
    }
}
