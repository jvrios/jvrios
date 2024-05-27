namespace ImagensApp.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string ImageId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateAdded { get; set; }
    }
}