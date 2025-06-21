public class AttendanceService
{
    public List<Attendee> Participants { get; set; } = new();

    public void Register(string name, string email, int eventId)
    {
        Participants.Add(new Attendee
        {
            Id = Guid.NewGuid(),
            Name = name,
            Email = email,
            RegisteredAt = DateTime.UtcNow,
            EventId = eventId
        });
    }

    public void MarkAttendance(Guid id)
    {
        var attendee = Participants.FirstOrDefault(a => a.Id == id);
        if (attendee != null)
            attendee.HasAttended = true;
    }
}

public class Attendee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool HasAttended { get; set; }
    public DateTime RegisteredAt { get; set; }

    public int EventId { get; set; }
}
