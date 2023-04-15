using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Auth
{
    public class AuthModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameIdentifier { get; set; }
        public string Role { get; set; }
    }
}
