namespace ProductsManagement.Controllers
{
    using Ninject.Infrastructure.Language;
    using ProductsManagement.Core.Entities;
    using ProductsManagement.Models;
    using ProductsManagement.Services.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
        public async Task<ActionResult> Index(string persistType)
        {
            var persistenceitems = new string[] {"DataBase", "Memory"};
            if (persistType == "Memory")
            {
                IEnumerable<ProductsModel> productsSession;
                productsSession = System.Web.HttpContext.Current.Session["productsSession"] as IEnumerable<ProductsModel>;
                ViewBag.Persistence = new SelectList(persistenceitems, "Memory");
                if (productsSession != null)
                {
                    return View(productsSession);
                }
                else
                {
                    List<ProductsModel> lstProductsModels = new List<ProductsModel>();
                    return View(lstProductsModels.ToEnumerable());
                }
                
            }
            else
            {

                var client = new HttpClient();
                string path = Request.Url.GetLeftPart(UriPartial.Authority);
                var response = await client.GetAsync(path + $"/api/ProductsApi");
                var products = await response.Content.ReadAsAsync<IEnumerable<ProductsModel>>();
                ViewBag.Persistence = new SelectList(persistenceitems, "DataBase");
                return View(products);
            }
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult CreateMemory()
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

        [HttpPost]
        public ActionResult CreateMemory(Products product)
        {
            var prod = new ProductsModel();
            try
            {
                var productsSession =
                    System.Web.HttpContext.Current.Session["productsSession"] as IEnumerable<ProductsModel>;

                prod.Title = product.Title;
                prod.AddDate = DateTime.Now;
                prod.Ip = this.Request.UserHostAddress;
                prod.Price = product.Price;
                prod.ProductNumber = product.ProductNumber;

                List<ProductsModel> lstProd;

                if (productsSession == null)
                {
                    lstProd = new List<ProductsModel>();
                }
                else
                {
                    lstProd = productsSession.ToList();
                }

                lstProd.Add(prod);

                System.Web.HttpContext.Current.Session["productsSession"] = lstProd.ToEnumerable();

                return RedirectToAction("Index", new { PersistType = "Memory" });

            }
            catch
            {
                return View();
            }
        }
    }
}
