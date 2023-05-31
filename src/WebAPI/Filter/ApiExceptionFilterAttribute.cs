using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Filter
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandlers;

        public ApiExceptionFilterAttribute()
        {
            _exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>
            {
                //{ typeof(ValidationException), HandleValidationException },
                //{ typeof(NotFoundException), HandleNotFoundException },
                //{ typeof(UnauthorizedAccessException), HandleUnauthorizedAccessException },
                //{ typeof(ForbiddenAccessException), HandleForbiddenAccessException },
            };
        }
    }
}
