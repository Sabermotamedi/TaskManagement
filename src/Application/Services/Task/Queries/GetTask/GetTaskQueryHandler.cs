using Application.Common.Interface;
using Application.Models.Task;
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
            var res = await _context.Tasks.ToListAsync();
            return res.ToDto();

        }
    }
}
