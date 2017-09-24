namespace ProductsManagement.Core.Entities
{
    /// <summary>
    /// Represents the details of the products
    /// </summary>
    public class Products : BaseClass
    {
        public int ProductNumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
