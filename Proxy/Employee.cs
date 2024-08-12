using System;
namespace Prototype
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public ContactInfo ContactInfo { get; set; }

        public abstract Employee GetClone();

        public abstract void GetDetails();
    }
}
