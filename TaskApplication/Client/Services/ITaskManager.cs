using TaskApplication.Shared.Models;

namespace TaskApplication.Client.Services
{
    public interface ITaskManager
    {
        Task<List<TaskModel>> GetAllTasks(string Apiname);
        Task<TaskModel> UpdateTask(TaskModel taskModel,string Apiname);
        Task<TaskModel> GetOneTask(string Apiname);
    }
}
