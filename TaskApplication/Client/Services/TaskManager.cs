using System.Net.Http.Json;
using TaskApplication.Shared.Models;

namespace TaskApplication.Client.Services
{
    public class TaskManager : ITaskManager
    {
        private readonly HttpClient httpClient;

        public TaskManager(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<TaskModel>> GetAllTasks(string Apiname)
        {
            return await httpClient.GetFromJsonAsync<List<TaskModel>>(Apiname);
        }

        public async Task<TaskModel> GetOneTask(string Apiname)
        {
            return await httpClient.GetFromJsonAsync<TaskModel>(Apiname);
        }

        public async Task<TaskModel> UpdateTask(TaskModel taskModel, string Apiname)
        {
            var result = await httpClient.PutAsJsonAsync<TaskModel>(Apiname,taskModel);
            return await result.Content.ReadFromJsonAsync<TaskModel>() ;
        }
    }
}
