using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class PromosRepository : IPromosRepository<Promo>
    {
        private const string DateFormat = "yyyy-MM-dd";

        public Promo GetById(int id_promo)
        {
            Promo promo = null;
            try
            {                
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //ОТкрытие соединения

                var selectsPromoSql = "SELECT * FROM promos WHERE id_promos = @id_promos;"; //Sql запрос получения акции по id

                using var selectCommand = new MySqlCommand(selectsPromoSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@id_promos", id_promo); //Подстановка id в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                if (reader.Read())
                {
                    int id_promos = reader.GetInt32(0); //Считать id
                    string name = reader.GetString(1); //Считать название
                    string description = null;
                    if (!reader.IsDBNull(2) && reader.GetString(2) != "")
                     description = reader.GetString(2); //Считать описание, если оно не пустое
                    string promo_conditions = reader.GetString(3); //Считать условия
                    DateOnly start_date = DateOnly.FromDateTime(reader.GetDateTime(4)); //Считать дату начала
                    DateOnly end_date = DateOnly.FromDateTime(reader.GetDateTime(5)); //Считать дату окончания
                    float promo_percent = reader.GetFloat(6); //Считать размер акции

                    promo = new Promo(id_promos, name, description, promo_conditions, start_date, end_date, promo_percent);
                }

                return promo;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return promo;
            }
        }

        public Promo[] GetCurrentPromos()
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectPromosSql = "SELECT * FROM promos WHERE @curDate >= start_date and @curDate <= end_date;"; //Sql запрос получения действующих акций

                using var selectCommand = new MySqlCommand(selectPromosSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@curDate", DateTime.Today.ToString(DateFormat)); //Подстановка текущей даты в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var promos = new List<Promo>(); //Список содержащий искомые акции

                while (reader.Read())
                {
                    int id = reader.GetInt32(0); //Считывание id
                    string name = reader.GetString(1); //Считывание названия
                    string description = null;
                    if (!reader.IsDBNull(2) && reader.GetString(2) != "")
                        description = reader.GetString(2); //Считать описание, если оно не пустое
                    string promo_conditions = reader.GetString(3); //Считывание условий акции
                    DateOnly start_date = DateOnly.FromDateTime(reader.GetDateTime(4)); //Считать дату начала
                    DateOnly end_date = DateOnly.FromDateTime(reader.GetDateTime(5)); //Считать дату окончания
                    float promo_percent = reader.GetFloat(6); //Считать размер акции

                    promos.Add(new Promo(id, name, description, promo_conditions, start_date, end_date, promo_percent));
                }

                return promos.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Promo[] { };
            }
        }

        public Product[] GetProductsFromPromo(Promo existingPromo)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectProductsSql = @"SELECT products.product_code, products.name, products.price FROM promos
                                      JOIN products_to_promos AS ptp ON promos.id_promos = ptp.id_promo
                                      JOIN products ON products.product_code = ptp.product_code
                                      WHERE promos.id_promos = @id_promo;"; //Sql запрос получения всех продуктов, участвующих в акцции

                using var selectCommand = new MySqlCommand(selectProductsSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@id_promo", existingPromo.Id_promos); //Подстановка id акции в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var products = new List<Product>(); //Список всех продуктов в акции

                while (reader.Read())
                {
                    int product_code = reader.GetInt32(0); //Считать код продукта
                    string name = reader.GetString(1); //Считать название продукта
                    int price = reader.GetInt32(2); //Считать цену продукта

                    products.Add(new Product(product_code, name, price)); //Добавить продукт в список
                }

                return products.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Product[] { };
            }
        }
    }
}
