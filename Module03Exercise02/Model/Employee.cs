using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Exercise02.Model
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullnames => $"{FirstName} {LastName}";
        public string Informations => $"Position: " + $"{Position}" + $" | " + $"Department: " + $"{Department}" + $" | " + $"Status: " + $"{IsActive}";
        public string Position { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
    }
}
