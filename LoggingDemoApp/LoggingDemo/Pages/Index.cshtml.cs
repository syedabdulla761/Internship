using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {

        //standard way of capturing the category
     /*   private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }*/

        //creating your own category:
        private readonly ILogger _logger;

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("LoggingDemo App Category");
        }



        public void OnGet()
        {
            //The Logging levels:
            _logger.LogTrace(1, "This is a trace log");
            _logger.LogDebug(2, "This is a Debug log");
            _logger.LogInformation(3, "This is a Information log");
            _logger.LogWarning(4, "This is a Warning log");
            _logger.LogError(5, "This is a Error log");
            _logger.LogCritical(6, "This is a Critical log");


            //Advancedd logging messages:
            /* _logger.LogError("The server went down temporarily at {Time}",DateTime.UtcNow);

             try
             {
                 throw new Exception("Random Exception");
             }
             catch (Exception ex) 
             {
                 _logger.LogCritical(ex, "There was a bad exception at {Time}", DateTime.UtcNow);

             }*/
        }

        public class LoggerId
        {
           public const int DemoId = 1;
        }
    }
}