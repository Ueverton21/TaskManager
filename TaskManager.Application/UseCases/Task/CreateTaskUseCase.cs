using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;

public class CreateTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        var task = new ResponseTaskJson
        {
            DateLimit = request.DateLimit,
            Description = request.Description,
            Name = request.Name,
            Priority = request.Priority,
            Status = request.Status
        };

        return task;
    }
}
