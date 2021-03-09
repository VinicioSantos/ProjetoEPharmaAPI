using Microsoft.AspNetCore.Mvc;
using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Service.Modules;
using System.Threading.Tasks;

namespace ProjetoEPharma.Interface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoController : ControllerBase
    {
        private readonly PlanoApplicationService _appService;

        public PlanoController(PlanoApplicationService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Post(PlanoDto dto)
        {
            return Ok(await _appService.SalvaPlano(dto));
        }
    }
}
