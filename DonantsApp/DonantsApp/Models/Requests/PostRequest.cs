namespace DonantsApp.Models.Requests
{
    public class PostRequest
    {
        public string Title { get; set; }
        public required string Description { get; set; }
        public string Image { get; set; }
        public DateTime PostDate { get; set; }
        public int AccountId { get; set; }
        public int DonationTypeId { get; set; }
        public int PostTypeId { get; set; }
        public int StatusId { get; set; }
    }
}
