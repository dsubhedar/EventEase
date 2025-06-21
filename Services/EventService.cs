    public class EventService
    {
    private readonly List<Event> _events = new()
    {
        new Event { Id = 1, Name = "Tech Conference", Date = new DateTime(2025, 5, 20), Location = "San Francisco" },
        new Event { Id = 2, Name = "Marketing Summit", Date = new DateTime(2025, 6, 15), Location = "Los Angeles" }
    };

     public List<Event> GetEvents() => _events;
    public string GetEventName(int id)
    {
        var ev = _events.Find(e => e.Id == id);
        return ev?.Name ?? "Unknown Event";
    }

}
