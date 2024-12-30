namespace DonantsApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public BloodType BloodType { get; set; }

        public string Image { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Ci { get; set; }
    }
}
