using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Notification : BaseEntity
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public Employee Employee { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
