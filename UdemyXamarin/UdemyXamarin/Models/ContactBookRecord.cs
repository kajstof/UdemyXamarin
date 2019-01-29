using SQLite;

namespace UdemyXamarin.Models
{
    [Table("Contacts")]
    public class ContactBookRecord
    {
        [PrimaryKey, AutoIncrement, Column("ContactID")]
        public int ID { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        public bool IsBlocked { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}