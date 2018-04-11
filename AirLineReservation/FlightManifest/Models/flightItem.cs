namespace FlightManifest.Models
{
    public class flightItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Seat {get; set;}
        public bool IsComplete { get; set; }
    }
}