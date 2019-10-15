namespace ProductsManagement.Data
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public static class ParamHelper
    {
        internal static string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        internal static SqlParameter CreateParameter(string name, SqlDbType type, ParameterDirection direction, object valor)
        {
            var parameter = new SqlParameter("@" + name, type)
            {
                Direction = direction,
                Value = valor
            };

            return parameter;
        }
    }
}
