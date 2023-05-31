﻿using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Queries.GetTask
{
    public class GetTaskQuery : IRequest<List<TaskDto>>
    {
    }
}
