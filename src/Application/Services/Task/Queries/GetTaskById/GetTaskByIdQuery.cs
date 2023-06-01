using Application.Models.Task;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Queries.GetTaskById
{
    public class GetTaskByIdQuery : IRequest<TaskDto>
    {
        public int Id { get; set; }
    }
}
