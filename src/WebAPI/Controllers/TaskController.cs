using Application.Services.Task.Commands.CreateTask;
using Application.Services.Task.Commands.DeleteTask;
using Application.Services.Task.Commands.UpdateTask;
using Application.Services.Task.Queries.GetTask;
using Application.Services.Task.Queries.GetTaskById;
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
            var Tasks = await Mediator.Send(new GetTaskQuery());
            return Ok(Tasks);
        }

        [HttpGet("{id:int}", Name = nameof(GetTaskById))]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var Task = await Mediator.Send(new GetTaskByIdQuery() { Id = id });
            return Ok(Task);
        }

        [HttpPost(Name = nameof(AddTask))]
        public async Task<IActionResult> AddTask(CreateTaskCommand task) => Ok(await Mediator.Send(task));

        [HttpPut(Name = nameof(UpdateTask))]
        public async Task<IActionResult> UpdateTask(UpdateTaskCommand task) => Ok(await Mediator.Send(task));

        [HttpDelete("{id:int}", Name = nameof(DeleteTask))]
        public async Task<IActionResult> DeleteTask(int id) => Ok(await Mediator.Send(new DeleteTaskCommand() { Id = id }));

    }
}