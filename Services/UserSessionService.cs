public class UserSessionService
{
    public string SessionId { get; } = Guid.NewGuid().ToString();
    public DateTime StartTime { get; } = DateTime.UtcNow;
    public string UserAgent { get; set; }
    public string IPAddress { get; set; }
}
