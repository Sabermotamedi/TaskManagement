﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Commands.DeleteTask
{
    public class DeleteTaskCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
