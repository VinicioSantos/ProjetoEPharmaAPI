using Microsoft.AspNetCore.Mvc;
using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Service.Modules;
using System.Threading.Tasks;

namespace ProjetoEPharma.Interface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteApplicationService _appService;

        public ClienteController(ClienteApplicationService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Post(SalvaClienteDto dto)
        {
            return Ok(await _appService.SalvaCliente(dto));
        }
    }
}
