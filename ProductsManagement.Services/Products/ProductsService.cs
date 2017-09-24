namespace ProductsManagement.Services.Products
{
    using ProductsManagement.Data.Products;
    using System;
    using System.Collections.Generic;
    /// <inheritdoc />
    public class ProductsService : IProductsService
    {
        private IProductsRepository _repository;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="productsRepository"></param>
        public ProductsService(IProductsRepository productsRepository)
        {
            this._repository = productsRepository;
        }

        /// <inheritdoc />
        public List<Core.Entities.Products> GetProducts()
        {
            try
            {
                return _repository.GetProducts();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <inheritdoc />
        public bool CreateProduct(Core.Entities.Products product)
        {
            try
            {
                return _repository.CreateProduct(product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
