﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public int Wage { get; set; }

    }
}
