namespace ProductsManagement.Data
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;

    public static class ParamHelper
    {
        internal static string getConnString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        internal static SqlParameter CreateParameter(string nombre, SqlDbType tipo, ParameterDirection direccion, object valor)
        {
            SqlParameter parameter = new SqlParameter("@" + nombre, tipo);
            parameter.Direction = direccion;
            parameter.Value = valor;

            return parameter;
        }
    }
}
