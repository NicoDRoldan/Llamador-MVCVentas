using Microsoft.AspNetCore.Mvc;
using Llamador.Models;
using Newtonsoft.Json;
using Llamador.Services;

namespace Llamador.Controllers
{
    public class LlamadorController : Controller
    {
        private readonly LlamadorService _llamadorService;

        public LlamadorController(LlamadorService llamadorService)
        {
            _llamadorService = llamadorService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<OrderGroupModel> orderGroups = await _llamadorService.GetOrderGroupsAsync();
            return View(orderGroups);
        }
    }
}
