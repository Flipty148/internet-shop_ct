using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class OrdersRepository : IOrdersRepository<Order>
    {
        public Order Add(Order newOrder, int userCode)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var insertOrderSql = @"INSERT INTO orders (`time_&_date`, payment_method, user_code, `id_pick-up_point`)
                                   VALUES (@date_and_time, @payment_method, @user_code, @id_pick_up_point);"; //Sql запрс добавления заказа

                //Преобразование типа оплаты в строку
                string payment;
                switch (newOrder.Payment_method)
                {
                    case Order.PaymentMethod.ONLINE:
                        payment = "online";
                        break;
                    case Order.PaymentMethod.CASH:
                        payment = "cash";
                        break;
                    case Order.PaymentMethod.CARD:
                        payment = "card";
                        break;
                    default:
                        payment = "default";
                        break;
                }

                using var insertOrderCommand = new MySqlCommand(insertOrderSql, connection); //Создание команды добавления заказа

                insertOrderCommand.Parameters.AddWithValue("@date_and_time", newOrder.Date_and_time.ToString("yyyy-MM-dd HH:mm:ss")); //Подстановка даты и времени в команду
                insertOrderCommand.Parameters.AddWithValue("@payment_method", payment); //Подстановка способа оплаты в команду
                insertOrderCommand.Parameters.AddWithValue("@user_code", userCode); //Подстановка кода пользователя в команду
                insertOrderCommand.Parameters.AddWithValue("@id_pick_up_point", newOrder.Order_pick_up_point.id); //Подстановка ID пункта выдачи в команду

                insertOrderCommand.ExecuteNonQuery(); //Выполнение команды добавления заказа
                int lastId = Convert.ToInt32(insertOrderCommand.LastInsertedId); //Номер добавленного заказа

                Order returnedOrder = new Order(lastId, newOrder.Date_and_time, newOrder.Payment_method, newOrder.Order_pick_up_point); //Возвращаемый зака

                var insertProductsSql = "INSERT INTO products_to_orders (product_code, order_code, count) VALUES (@product_code, @order_code, @count)"; //Sql запрос добавления товара в заказ

                using var insertProductsCommand = new MySqlCommand(insertProductsSql, connection); //Создание команды добавления товара в заказ

                int countProducts = newOrder.ProductsInOrder.Count(); //Общее количество товаров

                insertProductsCommand.Parameters.AddWithValue("@product_code", newOrder.ProductsInOrder[0].Product.Product_code); //Подстановка кода продукта в команду
                insertProductsCommand.Parameters.AddWithValue("@order_code", returnedOrder.Order_code); //Подстановка кода заказа в команду
                insertProductsCommand.Parameters.AddWithValue("@count", newOrder.ProductsInOrder[0].Count); //Подстановка количества товара в команду
                for (int i = 1; i < countProducts; i++)
                {
                    insertProductsCommand.Parameters["@product_code"].Value = newOrder.ProductsInOrder[i].Product.Product_code;
                    insertProductsCommand.Parameters["@count"].Value = newOrder.ProductsInOrder[i].Count; //Подстановка количества товара в команду

                insertProductsCommand.ExecuteNonQuery(); //Выполнение команды добавления товара в заказ
                }
                return returnedOrder;
            }
            catch(MySqlException ex)
            {
                throw new RepositoryException(ex.Message);
                return newOrder;
            }
        }

        public void Delete(Order existingOrder)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var deleteProductsSql = "DELETE FROM products_to_orders WHERE order_code = @order_code;"; //Sql запрос удаления продуктов из заказа

                using var deleteProductsCommand = new MySqlCommand(deleteProductsSql, connection); //Создание команды удаления продуктов из заказа

                deleteProductsCommand.Parameters.AddWithValue("@order_code", existingOrder.Order_code); //Подстановка номера заказа в команду

                deleteProductsCommand.ExecuteNonQuery(); //Выполнение команды удаления товаров из заказа

                var deleteOrderSql = "DELETE FROM orders WHERE order_code = @order_code;"; //Sql запрос удаления заказа

                using var deleteOrderCommand = new MySqlCommand(deleteOrderSql, connection); //Создание команды удаления заказа

                deleteOrderCommand.Parameters.AddWithValue("@order_code", existingOrder.Order_code); //Подстановка кода заказа в команду

                deleteOrderCommand.ExecuteNonQuery(); //Выполнение команды удаления заказа
            }
            catch(MySqlException ex)
            {
                throw new RepositoryException(ex.Message);
            }
        }

        public Order.OrderPickUpPoint[] GetAllPickUpPoints()
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectPickUpPointsSql = @"SELECT * FROM `order_pick-up_points`;"; //Sql запрос получения пунктов выдачи

                using var selectPickUpPointsCommand = new MySqlCommand(selectPickUpPointsSql, connection); //Создание команды

                using var reader = selectPickUpPointsCommand.ExecuteReader(); //Выполнение команды

                List<Order.OrderPickUpPoint> pickUpPoints = new List<Order.OrderPickUpPoint>(); //Список пунктов выдачи
                while (reader.Read())
                {
                    int id = reader.GetInt32(0); //ID
                    string name = reader.GetString(1); //Название
                    string address = reader.GetString(2); //Адрес

                    pickUpPoints.Add(new Order.OrderPickUpPoint { id = id, name = name, address = address });
                }

                return pickUpPoints.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return null;
            }
        }

        public Order GetByOrderCode(int order_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //ОТкрытие соединения

                var selectOrderSql = @"SELECT `time_&_date`, payment_method, `name`, address, o.`id_pick-up_point` FROM orders AS o
                                       JOIN `order_pick-up_points` AS opup ON opup.`id_order_pick-up_points` = o.`id_pick-up_point`
                                       WHERE o.order_code = @order_code;"; //Sql запрос получения заказа по его коду

                using var selectOrderCommand = new MySqlCommand(selectOrderSql, connection); //Создание команды

                selectOrderCommand.Parameters.AddWithValue("@order_code", order_code); //Подстановка кода заказа в команду

                using var reader = selectOrderCommand.ExecuteReader(); //Выполнение команды

                Order order = null;
                if (reader.Read())
                {
                    DateTime date_and_time = reader.GetDateTime(0); //Считать дату и время
                    string payment = reader.GetString(1); //Считать способ оплаты
                    //Преобразовать способ оплаты
                    Order.PaymentMethod payment_method; 
                    switch (payment)
                    {
                        case "online":
                            payment_method = Order.PaymentMethod.ONLINE;
                            break;
                        case "cash":
                            payment_method = Order.PaymentMethod.CASH;
                            break;
                        case "card":
                            payment_method = Order.PaymentMethod.CARD;
                            break;
                        default:
                            payment_method = Order.PaymentMethod.ONLINE;
                            break;
                    }
                    Order.OrderPickUpPoint orderPickUpPoint = new() { name = reader.GetString(2), address = reader.GetString(3), id = reader.GetInt32(4) }; //Считать пункт выдачи

                    order = new Order(order_code, date_and_time, payment_method, orderPickUpPoint); //Создать заказ
                }
                return order;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return null;
            }
        }

        public Order[] GetOrdersByUser(int user_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectOrdersSql = @"SELECT o.order_code,`time_&_date`, payment_method, `name`, address, o.`id_pick-up_point` FROM orders AS o
                                       JOIN `order_pick-up_points` AS opup ON opup.`id_order_pick-up_points` = o.`id_pick-up_point`
                                       WHERE o.user_code = @user_code;"; //Sql запрос получения заказов пользователя

                using var selectOrdersCommand = new MySqlCommand(selectOrdersSql, connection); //Создание команды
                
                selectOrdersCommand.Parameters.AddWithValue("@user_code", user_code); //Подстановка кода пользователя в команду

                using var reader = selectOrdersCommand.ExecuteReader(); //Выполнение команды

                var orders = new List<Order>(); //Список для заказов пользователя

                while (reader.Read())
                {
                    int order_code = reader.GetInt32(0);
                    DateTime date_and_time = reader.GetDateTime(1); //Считать дату и время
                    string payment = reader.GetString(2); //Считать способ оплаты
                                                          //Преобразовать способ оплаты
                    Order.PaymentMethod payment_method;
                    switch (payment)
                    {
                        case "online":
                            payment_method = Order.PaymentMethod.ONLINE;
                            break;
                        case "cash":
                            payment_method = Order.PaymentMethod.CASH;
                            break;
                        case "card":
                            payment_method = Order.PaymentMethod.CARD;
                            break;
                        default:
                            payment_method = Order.PaymentMethod.ONLINE;
                            break;
                    }
                    Order.OrderPickUpPoint orderPickUpPoint = new() { name = reader.GetString(3), address = reader.GetString(4), id = reader.GetInt32(5) }; //Считать пункт выдачи

                    orders.Add(new Order(order_code, date_and_time, payment_method, orderPickUpPoint)); //Добавить заказ
                }

                return orders.ToArray();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Order[] { };
            }
        }

        public Order GetProductsByOrder(Order existingOrder)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection();

                connection.Open();

                var selectProductsSql = "CALL productsInOrder(@order_code);";

                using var selectProductsCommand = new MySqlCommand(selectProductsSql, connection);

                selectProductsCommand.Parameters.AddWithValue("@order_code", existingOrder.Order_code);

                using var reader = selectProductsCommand.ExecuteReader();

                Order newOrder = new Order(existingOrder);
                while (reader.Read())
                {
                    int product_code = reader.GetInt32(1);
                    string name = reader.GetString(2);
                    int price = reader.GetInt32(4);
                    int count = reader.GetInt32(3);

                    Product curProduct = new Product(product_code, name, price);
                    Order.ProductInOrder productInOrder = new Order.ProductInOrder{ Product = curProduct, Count = count };
                    newOrder.appendProductToOrder(productInOrder);
                }

                return newOrder;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return null;
            }
        }

        public User GetUserByOrder(Order existingOrder)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectUserSql = @"SELECT u.user_code, phone_number, name, password, registration_date FROM orders AS o
                                  JOIN users AS u ON u.user_code = o.user_code
                                  WHERE order_code = @order_code;"; //Sql запрос получения пользователя по заказу

                using var selectUserCommand = new MySqlCommand(selectUserSql, connection); //Создание команды

                selectUserCommand.Parameters.AddWithValue("@order_code", existingOrder.Order_code); //Подстановка кода заказа в команду

                using var reader = selectUserCommand.ExecuteReader(); //Выполнение команды

                User user = null;
                if (reader.Read())
                {
                    int user_code = reader.GetInt32(0); //Считать код пользователя
                    int phone_number = reader.GetInt32(1); //Считать номер телефона
                    string name = reader.GetString(2); //Считать имя
                    string password = reader.GetString(3); //Считать пароль
                    DateOnly registration_date = DateOnly.FromDateTime(reader.GetDateTime(4)); //Считать дату регистрации

                    user = new User(user_code, phone_number, name, password, registration_date); //Создать пользователя
                }
                return user;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return null;
            }
        }

        public int TotalOrderCost(int order_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открыть соединение

                var totalSql = @"select sum(p.price*pto.count) from orders as o
	                             join products_to_orders as pto on pto.order_code = o.order_code
	                             join products as p on pto.product_code = p.product_code
	                             where o.order_code = @order_code;"; //Sql запрос стоимости заказа

                using var totalCommand = new MySqlCommand(totalSql, connection); //Создание команды

                totalCommand.Parameters.AddWithValue("@order_code", order_code); //Подстановка параметров

                using var reader = totalCommand.ExecuteReader(); //Выполнение команды
                int total = 0;
                if (reader.Read())
                {
                    total = reader.GetInt32(0);
                }
                return total;
            }
            catch (MySqlException)
            {
                return 0;
            }

        }

        public Order Update(Order existingOrder)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var updateOrderSql = @"UPDATE orders
                                   SET `id_pick-up_point` = @id_pick_up_point
                                   WHERE order_code = @order_code;"; //Sql запрос обновления

                using var updateOrderCommand = new MySqlCommand(updateOrderSql, connection); //Создание команды

                updateOrderCommand.Parameters.AddWithValue("@id_pick_up_point", existingOrder.Order_pick_up_point.id); //Подстановка Id пункта выдачи в команду
                updateOrderCommand.Parameters.AddWithValue("@order_code", existingOrder.Order_code); //Подстановка номера заказа в команду

                updateOrderCommand.ExecuteNonQuery(); //Выполнение команды

                var selectPickUpPointSql = "SELECT * FROM `order_pick-up_points` WHERE `id_order_pick-up_points` = @id_pick_up_point;"; //Sql запрос получения пункта выдачи по ID

                using var selectCommand = new MySqlCommand(selectPickUpPointSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@id_pick_up_point", existingOrder.Order_pick_up_point.id); //Подстановка Id пункта выдачи в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                Order.OrderPickUpPoint pickUpPoint = existingOrder.Order_pick_up_point;

                if (reader.Read())
                {
                    int id = reader.GetInt32(0); //Считывание ID
                    string name = reader.GetString(1); //Считывание названия
                    string address = reader.GetString(2); //Считывание адреса

                    pickUpPoint = new() { id = id, name = name, address = address }; //Новые данные пункта выдачи
                }

                return new Order(existingOrder.Order_code, existingOrder.Date_and_time, existingOrder.Payment_method, pickUpPoint);
            }
            catch(MySqlException ex)
            {
                throw new RepositoryException(ex.Message);
                return null;
            }
        }
    }
}
