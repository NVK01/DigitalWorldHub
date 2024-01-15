using DigitalWorldHub.Server.Errors;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWorldHub.Server.Controllers
{
    public class ErrorController : BaseApiController
    {
        [Route("errors/{code}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
