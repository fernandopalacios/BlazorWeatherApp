public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public string Localtime { get; set; }
    public int FavoriteLocationId { get; set; }
    public string FullDate
    {
        get
        {
            DateTime dateTime = DateTime.Parse(Localtime);
            return dateTime.ToString("dddd d, HH:mm");
        }
    }
}