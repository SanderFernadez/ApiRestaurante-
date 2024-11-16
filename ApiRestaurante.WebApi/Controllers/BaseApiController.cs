using Microsoft.AspNetCore.Mvc;

namespace ApiRestaurante.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {

    }
}
