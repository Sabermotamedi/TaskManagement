using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Queries.GetTask
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, List<TaskDto>>
    {
        public Task<List<TaskDto>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
