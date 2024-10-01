using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; }
    public string Description { get; set; }
    public PriorityType Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public StatusType Status { get; set; }
}
