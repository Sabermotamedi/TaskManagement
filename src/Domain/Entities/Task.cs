using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Task : BaseEntity
    {
        public Task(string name, string description, TaskType type, PriorityLevel priority, StatusState status, DateTime dueDate)
        {
            Name = name;
            Description = description;
            Type = type;
            Priority = priority;
            Status = status;
            DueDate = dueDate;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public TaskType Type { get; set; }
        public PriorityLevel Priority { get; set; }
        public StatusState Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}
