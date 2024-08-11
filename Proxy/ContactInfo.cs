namespace Prototype
{
    public class ContactInfo
    {
        public string Address { get; set; }

        public ContactInfo GetClone()
        {
            return (ContactInfo)this.MemberwiseClone();
        }

    }
}
