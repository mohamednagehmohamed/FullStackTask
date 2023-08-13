using Microsoft.AspNetCore.Mvc;
using TaskApplication.Server.Interfaces;
using TaskApplication.Shared.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskApplication.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskInterface _taskInterface;

        public TaskController(ITaskInterface taskInterface)
        {
            _taskInterface = taskInterface;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_taskInterface.GetAllTasks());
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public IActionResult GetOneTask(int id)
        {
            return Ok(_taskInterface.GetOneTask(id));
        }

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id,TaskModel taskModel)
        {
            return Ok(_taskInterface.UpdateTask(id,taskModel));
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
