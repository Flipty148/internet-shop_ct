using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class ProductsRepository : IProductsRepository<Product>
    {

        private string ConnectString; //Строка подключения
        public ProductsRepository(string connectString = "Server=localhost;Database=internet-shop_ct;User=root;Password=root")
        {
            ConnectString = connectString;
        }
           
        public Product Add(Product newProduct)
        {
            try
            {
                using var connection = new MySqlConnection(ConnectString); //Соединение

                connection.Open(); //Открытие соединения

                var insertProductSql = @"INSERT INTO products (`name`, price) VALUES (@name, @price);"; //Sql запрос вставки полей товара

                using var insertCommand = new MySqlCommand(insertProductSql, connection); //Создание команды

                insertCommand.Parameters.AddWithValue("@name", newProduct.Name); //Подстановка значения поля name в команду 
                insertCommand.Parameters.AddWithValue("@price", newProduct.Price); //Подстановка значения поля price в команду

                insertCommand.ExecuteNonQuery();
                int id = Convert.ToInt32(insertCommand.LastInsertedId); //Выполнение команды и получение id добавленного товараs

                Product returnedProduct = new Product(id, newProduct.Name, newProduct.Price);

                return returnedProduct;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return Product.wrongProduct;
            }
        }

        public void Delete(Product existingProduct)
        {
            try
            {
                using var connection = new MySqlConnection(ConnectString); //Соединение

                connection.Open(); //Открытие соединения

                var deleteProductSql = "DELETE FROM products WHERE product_code = @product_code;"; //Sql запрос удаления товара

                using var deleteCommand = new MySqlCommand(deleteProductSql, connection); //Создание комманды

                deleteCommand.Parameters.AddWithValue("@product_code", existingProduct.Product_code); //Подстановка значения поля product_code в команду

                deleteCommand.ExecuteNonQuery(); //Выполнение комманды
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
            }
        }

        public Product Update(Product existingProduct)
        {
            try
            {
                using var connection = new MySqlConnection(ConnectString); //Соединение

                connection.Open(); //Открытие соединения

                var updateProductSql = @"UPDATE products
                                      SET name = @updateName, price = @updatePrice
                                      WHERE product_code = @product_code"; //Sql запрос обновления товара

                using var updateCommand = new MySqlCommand(updateProductSql, connection); //Создание команды

                updateCommand.Parameters.AddWithValue("@updateName", existingProduct.Name); //Подстановка нового значения поля name в команду
                updateCommand.Parameters.AddWithValue("@updatePrice", existingProduct.Price); //Подстановка нового значения поля price в команду
                updateCommand.Parameters.AddWithValue("@product_code", existingProduct.Product_code); //Подстановка значения поля product_code в команду

                updateCommand.ExecuteNonQuery(); //Выполнение команды

                return existingProduct;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return Product.wrongProduct;
            }
        }

        public Product[] GetAll()
        {
            try
            {
                using var connection = new MySqlConnection(ConnectString); //Соединение

                connection.Open(); //Открытие соединения

                var selectProductsSql = "SELECT * FROM products;"; //Sql запрос вывода всех товаров

                using var selectCommand = new MySqlCommand(selectProductsSql, connection); //Создание команды

                using var reader = selectCommand.ExecuteReader();//Выполнение команды (иниациализация reader)

                var products = new List<Product>(); //Список всех товаров

                while (reader.Read())
                {//Пока reader может считывать 
                    var productCode = reader.GetInt32(0); //Получение кода товара
                    var productName = reader.GetString(1); //Получение названия товара
                    var productPrice = reader.GetInt32(2); //Получение цены товара

                    products.Add(new Product(productCode, productName, productPrice)); //Добавление продукта в список
                }

                return products.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.ToString}");
                return new Product[] { };
            }
        }

        public Product GetByProductCode(int product_code)
        {
            Product product = null;
            try
            {
                using var connection = new MySqlConnection(ConnectString);//Соединение

                connection.Open(); //Открытие соединения

                var selectProductSql = "SELECT * FROM products WHERE product_code = @product_code;"; //Sql запрос получения продукта по его коду

                using var selectCommand = new MySqlCommand(selectProductSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@product_code", product_code); //Подстановка кода товара в запрос

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                if (reader.Read())
                {
                    var productName = reader.GetString(1); //Получение назввания продукта
                    var productPrice = reader.GetInt32(2); //Получение цены продукта

                    product = new Product(product_code, productName, productPrice); //Создание продукта
                }

                return product;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return Product.wrongProduct;
            }
        }
    }
}
