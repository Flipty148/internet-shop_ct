using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class CategoriesRepository : ICategoriesRepository<Category>
    {
        public Category[] GetAll()
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectCategoriesSql = "SELECT * FROM categories;"; //Sql запрос получения всех категорий

                using var selectCommand = new MySqlCommand(selectCategoriesSql, connection); //Создание команды

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var categories = new List<Category>(); //Список содержащий все категории

                while (reader.Read())
                {
                    int id = reader.GetInt32(0); //Считать id
                    string name = reader.GetString(1); //Считать название

                    categories.Add(new Category(id, name));
                }

                return categories.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Category[] { };
            }
        }

        public Category GetById(int id_category)
        {
            Category category = null;
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectCategorySql = "SELECT * FROM categories WHERE id_categories = @id_category;"; //Sql запрос получающий категорию по id

                using var selectCommand = new MySqlCommand(selectCategorySql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@id_category", id_category); //Подстановка id категории в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                if (reader.Read())
                {
                    int id = reader.GetInt32(0); //Считать id
                    string name = reader.GetString(1); //Считать имя

                    category = new Category(id, name);
                }

                return category;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return category;
            }
        }

        public Product[] GetProductsFromCategory(Category existingCategory)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectProductsSql = @"SELECT p.product_code, p.name, p.price FROM products_in_categories AS pic
                                      JOIN products AS p ON p.product_code = pic.product_code
                                      WHERE category = @category;"; //Sql запрос получающий товары в указанной категории
                
                using var selectCommand = new MySqlCommand(selectProductsSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@category", existingCategory.Name); //Подстановка названия категории в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                var products = new List<Product>(); //Список, содержащий все продукты данной категории

                while (reader.Read())
                {
                    int product_code = reader.GetInt32(0); //Считать код продукта
                    string name = reader.GetString(1); //Считать название товара
                    int price = reader.GetInt32(2); //Считать цену товара

                    products.Add(new Product(product_code, name, price));
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
