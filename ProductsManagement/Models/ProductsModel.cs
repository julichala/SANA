namespace ProductsManagement.Models
{
    using System;

    /// <summary>
    /// Represents the details of the products
    /// </summary>
    public class ProductsModel
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Ip { get; set; }
        public int ProductNumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}