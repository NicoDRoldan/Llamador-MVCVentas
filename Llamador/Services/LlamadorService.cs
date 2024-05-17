using Llamador.Models;
using Newtonsoft.Json;

namespace Llamador.Services
{
    public class LlamadorService
    {
        private readonly HttpClient _httpClient;

        public LlamadorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7200/api");
        }

        public async Task<IEnumerable<OrderGroupModel>> GetOrderGroupsAsync()
        {
            var response = await _httpClient.GetAsync("api/PedidoActuales/OrderGroup");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<OrderGroupModel>>(content);
            }
            return new List<OrderGroupModel>();
        }

    }
}
