using MySql.Data.MySqlClient;

namespace internet_shop_ct.SqlDbConnect
{
    public class SqlDbConnection
    {
        private static string connectionString = "Server=localhost;Database=internet-shop_ct;User=root;Password=root"; //Строка подключения
        public static MySqlConnection GetDbConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
