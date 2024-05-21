namespace SmartHomeApi.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Device> Devices { get; set; }
    }
}
