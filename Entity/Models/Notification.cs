using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Notification : BaseEntity
    {
        public string title { get; set; }
        public string Contents { get; set; }
        public string Editor { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
