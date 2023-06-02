using Application.Common.Interface;
using Application.Models.Task;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Queries.GetTask
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, List<TaskDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetTaskQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskDto>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
           // var res = await _context.Tasks.ToListAsync();
            // return res.ToDto();
            return getresult();

        }

        private List<TaskDto> getresult()
        {
            List<TaskDto> TaskDtos = new List<TaskDto>();


            var result = new TaskDto()
            {
                Id = 1,
                Name = "Count Salary",
                Description = "Count all of employee salry for this month\t",
                DueDate = DateTime.Now,
                Priority = Domain.Enums.PriorityLevel.Medium,
                Status = Domain.Enums.StatusState.ToDo,
                Type = Domain.Enums.TaskType.Change
            };

            TaskDtos.Add(result);

            var result1 = new TaskDto()
            {
                Id = 2,
                Name = "Send payment Documents",
                Description = "Send all of Documents salry for Mr.Johnson",
                DueDate = DateTime.Now,
                Priority = Domain.Enums.PriorityLevel.High,
                Status = Domain.Enums.StatusState.InProgress,
                Type = Domain.Enums.TaskType.Task
            };

            TaskDtos.Add(result1);

            return TaskDtos;
        }
    }
}
