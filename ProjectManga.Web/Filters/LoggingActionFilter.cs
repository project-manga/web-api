namespace ProjectManga.Web.Filters
{
    using System;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;

    public class LoggingActionFilter : IActionFilter
    {
        private readonly ILogger<LoggingActionFilter> logger;

        public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation($"Called {context.ActionDescriptor.DisplayName}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation($"Calling {context.ActionDescriptor.DisplayName}");
        }
    }
}