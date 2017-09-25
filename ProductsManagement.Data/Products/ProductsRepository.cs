namespace ProductsManagement.Data.Products
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <inheritdoc />
    public class ProductsRepository : IProductsRepository
    {
        public string ConnString { get; set; }

        public ProductsRepository()
        {
            this.ConnString = ParamHelper.getConnString();
        }

        /// <inheritdoc />
        public List<Products> GetProducts()
        {
            var lstProducts = new List<Products>();

            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                var command = new SqlCommand("getProducts", connection) {CommandType = CommandType.StoredProcedure};

                connection.Open();

                using (var myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var objProduct = new Products
                        {
                            Id = Convert.ToInt32(myReader["Id"]),
                            AddDate = Convert.ToDateTime(myReader["AddDate"]),
                            ModifiedDate = myReader["ModifiedDate"] == DBNull.Value
                                ? DateTime.MinValue
                                : Convert.ToDateTime(myReader["ModifiedDate"]),
                            Ip = Convert.ToString(myReader["Ip"]),
                            ProductNumber = Convert.ToInt32(myReader["ProductNumber"]),
                            Title = Convert.ToString(myReader["Title"]),
                            Price = Convert.ToDecimal(myReader["Price"])
                        };
                        lstProducts.Add(objProduct);
                    };
                }
            }
            return lstProducts;
        }

        /// <inheritdoc />
        public bool CreateProduct(Products product)
        {
            using (var connection = new SqlConnection(ConnString))
            {
                var command = new SqlCommand("addProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(ParamHelper.CreateParameter("pProductNumber", SqlDbType.Int, ParameterDirection.Input, product.ProductNumber));
                command.Parameters.Add(ParamHelper.CreateParameter("pTitle", SqlDbType.NVarChar, ParameterDirection.Input, product.Title));
                command.Parameters.Add(ParamHelper.CreateParameter("pPrice", SqlDbType.Decimal, ParameterDirection.Input, product.Price));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
