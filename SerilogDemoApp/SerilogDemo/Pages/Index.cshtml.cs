using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;

namespace SerilogDemo.Pages
{
  //  [Route("/")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You requested access to index");

            try
            {
                for (int i = 0; i < 24; i++)
                {

                    if (i <= 22) _logger.LogInformation("The value of i is {Ilogvariable}", i);
                    else throw new Exception($"Number is greater than 22 ,it is {i}");
                }
            }
            catch (Exception ex) {

                _logger.LogError("Exception caught: {exception}",ex);
            }
        }
    }
}