using Application.Services.Task.Commands.CreateTask;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class TaskController : ApiControllerBase
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = nameof(GetTask))]
        public async Task<IActionResult> GetTask()
        {

            return Ok(true);
        }

        [HttpGet("{id:int}", Name = nameof(GetTaskById))]
        public async Task<IActionResult> GetTaskById(int id)
        {

            return Ok(true);
        }

        [HttpPost(Name = nameof(AddTask))]
        public async Task<IActionResult> AddTask(CreateTaskCommand task)
        {
            var vm = await Mediator.Send(task);

            return Ok(true);
        }

        [HttpPut(Name = nameof(UpdateTask))]
        public async Task<IActionResult> UpdateTask(CreateTaskCommand task)
        {
            var vm = await Mediator.Send(task);

            return Ok(true);
        }

        [HttpDelete("{id:int}", Name = nameof(DeleteTask))]
        public async Task<IActionResult> DeleteTask(int id)
        {
            return Ok(true);
        }

    }
}