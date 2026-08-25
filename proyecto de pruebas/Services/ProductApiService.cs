using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using proyecto_de_pruebas.Models;

namespace proyecto_de_pruebas.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new System.Uri("http://localhost:8000/")
            };
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = await _httpClient.GetFromJsonAsync<List<Product>>("products");
            return products ?? new List<Product>();
        }
    }
}