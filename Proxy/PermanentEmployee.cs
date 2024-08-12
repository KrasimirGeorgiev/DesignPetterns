using Prototype;
using System;
namespace Prototype
{
    public class PermanentEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override Employee GetClone()
        {
            PermanentEmployee employee = (PermanentEmployee)this.MemberwiseClone();
            employee.ContactInfo = ContactInfo.GetClone();
            return employee;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}, Contact Info: {ContactInfo.Address}, Salary: {Salary}");
        }
    }
}
