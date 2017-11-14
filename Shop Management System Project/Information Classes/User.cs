namespace Shop_Management_System_Project.Information_Classes
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string JoinDate { get; set; }
        public string AccountType { get; set; }

        public User(string userName, string password, string name, string email, string address, string contactNo, string joinDate, string accountType)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Email = email;
            Address = address;
            ContactNo = contactNo;
            JoinDate = joinDate;
            AccountType = accountType;
        }
    }
}
