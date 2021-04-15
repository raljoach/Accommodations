namespace AccommodationService.Model
{
    public class AirbnbListing
    {
        public AirbnbListing() { }
        public AirbnbListing(string url)
        {
            this.Url = url;
        }

        public string Url { get; set; }
        public string PerNight { get; set; }
        public string Total { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
    }
}
