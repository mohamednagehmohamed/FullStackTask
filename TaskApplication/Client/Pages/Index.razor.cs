using Microsoft.AspNetCore.Components;
using MudBlazor;
using TaskApplication.Client.Services;
using TaskApplication.Shared.Models;

namespace TaskApplication.Client.Pages
{
    public partial class Index
    {
        [Inject]
        ISnackbar snackbar { get; set; }
        [Inject]
        public ITaskManager TaskManager { get; set; }
        List<TaskModel> taskModels { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            taskModels = await TaskManager.GetAllTasks("api/Task/GetAll");
            await base.OnInitializedAsync();
        }
        private async void UpdateTask(TaskModel taskModel,int taskId) 
        {
           await TaskManager.UpdateTask(taskModel,$"api/Task/UpdateTask/{taskId}");
            snackbar.Add("Task Became Completed", Severity.Success);
           // StateHasChanged();
            //if (taskModel.isCompleted)
            //    Console.WriteLine("Completed");
            //else
            //    Console.WriteLine("Not Completed");
        }
    }
}
