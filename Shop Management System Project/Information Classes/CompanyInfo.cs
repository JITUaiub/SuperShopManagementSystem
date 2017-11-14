namespace Shop_Management_System_Project.Information_Classes
{
    public class CompanyInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public CompanyInfo(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
