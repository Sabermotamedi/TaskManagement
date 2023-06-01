using FluentValidation;

namespace Application.Services.Task.Commands.CreateTask
{
    public class CreatTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        public CreatTaskCommandValidator()
        {
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
