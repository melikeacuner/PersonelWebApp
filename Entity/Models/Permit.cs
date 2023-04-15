using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Permit : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Explanation { get; set; }
        public Employee Employee{ get; set; }
        public string ApprovalStatus { get; set; }
    }
}
