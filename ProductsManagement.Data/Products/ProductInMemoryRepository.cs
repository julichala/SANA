namespace ProductsManagement.Data.Products
{
    using System.Collections.Generic;

    public sealed class ProductInMemoryRepository: IProductsRepository
    {
        private static readonly ProductInMemoryRepository _instance = new ProductInMemoryRepository();
        public List<Core.Entities.Products> LstProducts { get; set; }

        static ProductInMemoryRepository()
        {
        }

        private ProductInMemoryRepository()
        {
            LstProducts = new List<Core.Entities.Products>();
        }

        public static ProductInMemoryRepository Instance => _instance;

        public List<Core.Entities.Products> GetProducts()
        {
            return LstProducts;
        }

        public bool CreateProduct(Core.Entities.Products product)
        {
            LstProducts.Add(product);
            return true;
        }
    }
}
