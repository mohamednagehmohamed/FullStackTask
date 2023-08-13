using TaskApplication.Shared.Models;

namespace TaskApplication.Server.Interfaces
{
    public interface ITaskInterface
    {
        List<TaskModel> GetAllTasks();
        TaskModel UpdateTask(int taskid,TaskModel taskModel);
        TaskModel GetOneTask(int taskid);
    }
}
