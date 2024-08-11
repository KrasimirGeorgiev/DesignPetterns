using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public ContactInfo ContactInfo { get; set; }


        public Employee GetClone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.ContactInfo = ContactInfo.GetClone();
            return employee;
        }
    }
}
