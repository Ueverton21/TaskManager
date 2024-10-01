using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;

public class UpdateTaskUseCase
{
    public void Execute(int id, RequestUpdateTaskJson request)
    {
        var task = new RequestUpdateTaskJson
        {
            DateLimit = request.DateLimit,
            Description = request.Description,
            Name = request.Name,
            Priority = request.Priority,
            Status = request.Status
        };
    }
}
