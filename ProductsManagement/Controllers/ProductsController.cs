namespace ProductsManagement.Controllers
{
    using Ninject.Infrastructure.Language;
    using ProductsManagement.Core.Entities;
    using ProductsManagement.Services.Products;
    using System.Web.Mvc;

    /// <summary>
    /// Controller with actions for products (get and create)
    /// </summary>
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            this._productsService = productsService;
        }

        // GET: Products
        public ActionResult Index(string persistType)
        {
            var products = _productsService.GetProducts().ToEnumerable();
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
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
