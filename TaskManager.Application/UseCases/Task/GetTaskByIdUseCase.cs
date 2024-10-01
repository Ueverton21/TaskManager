using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task;

public class GetTaskByIdUseCase
{
    public ResponseShortTaskJson Execute(int id)
    {
        return new ResponseShortTaskJson();
    }
}
