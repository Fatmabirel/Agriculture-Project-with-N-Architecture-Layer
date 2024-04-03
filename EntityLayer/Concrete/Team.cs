using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        public int TeamId { get; set; }
        public required string PersonName { get; set; }
        public required string Title { get; set; }
        public required string ImageUrl { get; set; }
        public required string FacebookUrl { get; set; }
        public required string InstagramUrl { get; set; }
        public required string WebsiteUrl { get; set; }
        public required string TwitterUrl { get; set; }
    }
}
