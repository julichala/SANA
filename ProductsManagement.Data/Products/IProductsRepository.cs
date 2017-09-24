namespace ProductsManagement.Data.Products
{
    using Core.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Products repository to persists operations
    /// </summary>
    public interface IProductsRepository
    {
        /// <summary>
        /// Get all the products in repository
        /// </summary>
        /// <returns></returns>
        List<Products> GetProducts();

        /// <summary>
        /// Create a product in the repository
        /// </summary>
        /// <param name="product">Class product to create</param>
        /// <returns>True if the produc was sucesfully created</returns>
        bool CreateProduct(Products product);
    }
}
