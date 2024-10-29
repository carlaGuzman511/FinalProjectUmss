using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonantsApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public int PostId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
