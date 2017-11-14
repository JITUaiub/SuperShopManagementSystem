namespace Shop_Management_System_Project.Information_Classes
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public CustomerInfo(int customerId, string name, string address, string contactNo)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
            ContactNo = contactNo;
        }
    }
}
