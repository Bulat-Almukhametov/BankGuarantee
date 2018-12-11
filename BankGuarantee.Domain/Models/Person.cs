using System;
using System.Collections.Generic;
using System.Text;

namespace BankGuarantee.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public Appointment Appointment { get; set; }

        public Organization[] Organizations { get; set; }
    }
}
