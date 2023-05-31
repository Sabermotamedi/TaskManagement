using Application.Models;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Commands.UpdateTask
{
    public class UpdateTaskCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskType Type { get; set; }
        public PriorityLevel Priority { get; set; }
        public StatusState Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}
