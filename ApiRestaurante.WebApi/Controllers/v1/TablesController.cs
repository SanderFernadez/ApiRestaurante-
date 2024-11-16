using ApiRestaurante.Core.Application.Interfaces.Services;
using Asp.Versioning;


namespace ApiRestaurante.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class TablesController : BaseApiController
    {
        private readonly ITableService _tableService;

        public TablesController(ITableService tableService)
        {
            _tableService = tableService;
        }
    }
}
