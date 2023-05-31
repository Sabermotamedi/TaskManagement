using Application.Interface;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Task.Commands.CreateTask
{
    internal class CreatTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatTaskCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(v => v.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(500).WithMessage("Title must not exceed 500 characters.");

            RuleFor(v => v.DueDate)
                .LessThan(DateTime.Now.AddHours(1)).WithMessage("DueDate Should Be Greater Than Current DateTime");
        }
    }
}
