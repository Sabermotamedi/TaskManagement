using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Task
{
    public static class TaskExtensions
    {
        public static TaskDto ToDto(this Domain.Entities.Task task)
        {
            TaskDto result = null;
            if (task != null)
            {
                result = new TaskDto()
                {
                    Id = task.Id,
                    Name = task.Name,
                    Description = task.Description,
                    DueDate = task.DueDate,
                    Priority = task.Priority,
                    Status = task.Status,
                    Type = task.Type
                };
            }
            return result;
        }


        public static List<TaskDto> ToDto(this IEnumerable<Domain.Entities.Task> tasks)
        {
            List<TaskDto> TaskDtos = new List<TaskDto>();
            if (tasks != null && tasks.Count() > 0)
            {
                foreach (var task in tasks)
                {
                    var result = new TaskDto()
                    {
                        Id = task.Id,
                        Name = task.Name,
                        Description = task.Description,
                        DueDate = task.DueDate,
                        Priority = task.Priority,
                        Status = task.Status,
                        Type = task.Type
                    };
                    TaskDtos.Add(result);
                }
            }
            return TaskDtos;
        }


    }
}
