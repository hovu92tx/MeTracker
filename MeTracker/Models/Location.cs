using SQLite;

namespace MeTracker.Models
{
    public class Location
    {
        public Location() { }

        public Location(double latitude, double longtitude) 
        {
            Latitude = latitude;
            Longitude = longtitude;
        }
        [PrimaryKey, AutoIncrement]
        public int Id {  get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
