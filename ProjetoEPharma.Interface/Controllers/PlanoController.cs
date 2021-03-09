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

        /// <summary>
        /// Retorna Clientes
        /// </summary>
        /// <returns>Todos os clientes Cadastrados</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appService.ObterTodos());
        }

        /// <summary>
        /// Insere um plano
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>Valor do id do Plano</returns>
        [HttpPost]
        public async Task<IActionResult> Post(PlanoDto dto)
        {
            return Ok(await _appService.SalvaPlano(dto));
        }
    }
}
