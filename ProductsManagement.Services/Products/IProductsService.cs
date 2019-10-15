namespace ProductsManagement.Services.Products
{
    using System.Collections.Generic;
    using Core.Entities;

    /// <summary>
    /// Service for products.
    /// </summary>
    public interface IProductsService
    {

        /// <summary>
        /// Get all the products
        /// </summary>
        /// <returns></returns>
        List<Products> GetProducts();

        /// <summary>
        /// Create a product
        /// </summary>
        /// <param name="product">Class product to create</param>
        /// <returns>True if the product was successfully created</returns>
        bool CreateProduct(Products product);
    }
}
