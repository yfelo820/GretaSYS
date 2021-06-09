using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Greta.BO.Api.Controllers
{
    [EnableCors("AllowAllOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
