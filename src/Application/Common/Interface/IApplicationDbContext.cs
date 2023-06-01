using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IApplicationDbContext
    {
        public DbSet<Domain.Entities.Task> Tasks { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
