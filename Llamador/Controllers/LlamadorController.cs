using Microsoft.AspNetCore.Mvc;
using Llamador.Models;
using Newtonsoft.Json;

namespace Llamador.Controllers
{
    public class LlamadorController : Controller
    {
        private readonly HttpClient _httpClient;

        public LlamadorController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5000/api");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/PedidoActuales/OrderGroup");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var order = JsonConvert.DeserializeObject<IEnumerable<OrderGroupModel>>(content);
                return View(order);
            }
            return View(new List<OrderGroupModel>());
        }
    }
}
