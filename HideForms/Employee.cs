using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideForms
{
    public class Employee
    {
        public string RefNumber { get; set; } = null!;
        public string Name { get; set; } = null!;

        public Employee(string refNumber)
        {
            RefNumber = refNumber;
            Name = "N/A";
        }
    }
}
