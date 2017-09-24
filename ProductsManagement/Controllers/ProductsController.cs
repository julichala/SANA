namespace ProductsManagement.Controllers
{
    using ProductsManagement.Core.Entities;
    using ProductsManagement.Models;
    using ProductsManagement.Services.Products;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    /// <summary>
    /// Controller with actions for products (get and create)
    /// </summary>
    public class ProductsController : Controller
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            this._productsService = productsService;
        }

        // GET: Products
        public async Task<ActionResult> Index()
        {
            var client = new HttpClient();
            string path = Request.Url.GetLeftPart(UriPartial.Authority);
            var response = await client.GetAsync(path + $"/api/ProductsApi");
            var products = await response.Content.ReadAsAsync<IEnumerable<ProductsModel>>();
            return View(products);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Products product)
        {
            try
            {
                bool result = this._productsService.CreateProduct(product);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
