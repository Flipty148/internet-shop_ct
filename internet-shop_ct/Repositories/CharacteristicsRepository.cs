using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class CharacteristicsRepository : ICharacteristicsRepository<Characteristic>
    {
        public Characteristic[] GetAllByProduct(Product existingProduct)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectCharacteristicSql = @"SELECT  id_characteristics, ch.name, ch.description, cv.name FROM products AS p
                                            JOIN products_to_characteristic_values AS ptcv ON ptcv.product_Code = p.product_code
                                            JOIN characteristic_values AS cv ON cv.id_characteristic_values = ptcv.id_characteristic_values
                                            JOIN characteristics AS ch ON ch.id_characteristics = cv.id_characteristic
                                            WHERE p.product_code = @product_code;"; //Sql запрос получения характеристик и их значений для продукта

                using var selectCommand = new MySqlCommand(selectCharacteristicSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@product_code", existingProduct.Product_code); //Подстановка кода товара в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var characteristics = new List<Characteristic>(); //Список содержащий все характеристики товара

                while (reader.Read())
                {
                    int id = reader.GetInt32(0); //Считать ID характеристики
                    string name = reader.GetString(1); //Считать название характеристики
                    string description = null;
                    if (!reader.IsDBNull(2) && reader.GetString(2) != "")
                        description = reader.GetString(2); //Считать описание, если оно не пустое
                    string value = reader.GetString(3); //Считать значение характеристики

                    characteristics.Add(new Characteristic(id, name, description, value)); //Добавить характеристику
                }

                return characteristics.ToArray();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Characteristic[] { };
            }
        }

        public string[] GetValuesById(int id)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectValuesSql = @"SELECT cv.name FROM characteristics AS ch
                                    JOIN characteristic_values AS cv ON cv.id_characteristic = ch.id_characteristics
                                    WHERE ch.id_characteristics = @id;"; //Sql запрос получения всех значений указанной характеристики

                using var selectCommand = new MySqlCommand(selectValuesSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@id", id); //Подстановка ID в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var values = new List<string>(); //Список, содержащий все возможные значения характеристики

                while (reader.Read())
                {
                    string value = reader.GetString(0); //Считывание значения характеристики

                    values.Add(value); //Добавление характеристики 
                }

                return values.ToArray();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new string[] { };
            }
        }
    }
}
