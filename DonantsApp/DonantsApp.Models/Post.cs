using DonantsApp.Models.Enums;

namespace DonantsApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public required string Description { get; set; }
        public string Image { get; set; }
        public DateTime PostDate { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public DonationType DonationType { get; set; }
        public int DonationTypeId { get; set; }
        public required PostType PostType { get; set; }
        public int PostTypeId { get; set; }
        public Status Status { get; set; }
    }
}