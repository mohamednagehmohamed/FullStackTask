using TaskApplication.Shared.Models;

namespace TaskApplication.Server.Interfaces
{
    public class TaskInterface : ITaskInterface
    {
        private readonly TaskContext _context;

        public TaskInterface(TaskContext context)
        {
            _context = context;
        }

        public List<TaskModel> GetAllTasks()
        {
            return _context.TaskModels.ToList();
        }

        public TaskModel GetOneTask(int taskid)
        {
            return _context.TaskModels.FirstOrDefault(x=>x.taskId==taskid);
        }

        public TaskModel UpdateTask(int taskid,TaskModel taskModel)
        {
            var taskupdated = _context.TaskModels.FirstOrDefault(x=>x.taskId==taskid);
            taskupdated.isCompleted = taskModel.isCompleted;
            _context.SaveChanges();
            return taskupdated;
        }
    }
}
