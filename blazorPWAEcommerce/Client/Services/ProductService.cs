﻿

namespace blazorPWAEcommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if (result != null && result.Data != null)
            {
                products = result.Data;
            }
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productID)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productID}");
            return result;
        }
    }
}
