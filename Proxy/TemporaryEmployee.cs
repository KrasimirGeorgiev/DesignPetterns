namespace Prototype
{
    public class TemporaryEmployee: Employee
    {
        public decimal FixedAmount { get; set; }

        public override Employee GetClone()
        {
            TemporaryEmployee employee = (TemporaryEmployee)this.MemberwiseClone();
            employee.ContactInfo = ContactInfo.GetClone();
            return employee;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}, Contact Info: {ContactInfo.Address}, Fixed Mount: {FixedAmount}");
        }
    }
}
