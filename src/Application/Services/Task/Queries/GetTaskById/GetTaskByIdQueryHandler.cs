using Application.Common.Interface;
using Application.Models.Task;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Queries.GetTaskById
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDto>
    {
        private readonly IApplicationDbContext _context;

        public GetTaskByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TaskDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res.ToDto();
        }
    }
}
