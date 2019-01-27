namespace UdemyXamarin.Models
{
    public class ContactBookRecord
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}