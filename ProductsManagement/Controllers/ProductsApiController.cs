namespace ProductsManagement.Controllers
{
    using ProductsManagement.Core.Entities;
    using ProductsManagement.Services.Products;
    using System.Collections.Generic;
    using System.Web.Http;

    /// <summary>
    /// Api controller for products
    /// </summary>
    public class ProductsApiController : ApiController
    {
        private IProductsService _productsService;

        public ProductsApiController(IProductsService productsService)
        {
            this._productsService = productsService;
        }

        // GET: api/ProductsApi
        public List<Products> Get()
        {
            return this._productsService.GetProducts();
        }

        // GET: api/ProductsApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductsApi
        public void Post([FromBody]string value)
        {
        }
    }
}
