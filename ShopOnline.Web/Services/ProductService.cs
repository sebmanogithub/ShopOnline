﻿using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public HttpClient HttpClient { get; }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await httpClient
                    .GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
