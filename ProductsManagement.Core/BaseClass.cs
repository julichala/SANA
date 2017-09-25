namespace ProductsManagement.Core
{
    using System;

    /// <summary>
    /// Base class to be inheritaded for all the entities
    /// </summary>
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Ip { get; set; }
    }
}
