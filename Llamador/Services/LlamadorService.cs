using Llamador.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Llamador.Services
{
    public class LlamadorService
    {
        private readonly HttpClient _httpClient;

        public LlamadorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LlamadorModel> GetDataApi()
        {
            var response = await _httpClient.GetAsync("http://localhost:5000/api/PedidoActuales/PedidosActuales");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadFromJsonAsync<LlamadorModel>();
                return content;
            }

            return null;
        }
    }
}
