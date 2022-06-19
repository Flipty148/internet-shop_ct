using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class FeedbacksRepository : IFeedbacksRepository<Feedback>
    {
        public float AvgRating(int product_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var sqlStr = @"SELECT avg(f.rating) FROM feedbacks AS f
                           JOIN products AS p ON f.product_code = p.product_code
                           WHERE p.product_code = @product_code;"; //Sql запрос для получения среднего рейтинга продукта

                using var command = new MySqlCommand(sqlStr, connection); //Создание команды

                command.Parameters.AddWithValue("@product_code", product_code); //Подстановка кода товара в команду

                var reader = command.ExecuteReader(); //Выполнение команды

                float avg = 0; //Средняя оценка
                if (reader.Read())
                {
                    avg = reader.GetInt32(0); //Считать среднюю оценку
                }

                return avg;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return 0;
            }
        }

        public Feedback GetById(int id)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectFeedbackSql = "SELECT * FROM feedbacks WHERE id_feedback = @id;"; //Sql запрос получения отзыва по ID

                using var selectFeedbackCommand = new MySqlCommand(selectFeedbackSql, connection); //Создание команды

                selectFeedbackCommand.Parameters.AddWithValue("@id", id); //Подстановка ID в команду

                using var reader = selectFeedbackCommand.ExecuteReader(); //Выполнение команды

                Feedback feedback = null;
                if (reader.Read())
                {
                    int id_feedback = reader.GetInt32(0); //Считать Id
                    string comment = null;
                    if (reader.IsDBNull(1) && reader.GetString(1) != "")
                        comment = reader.GetString(1); //Считать комментарий, если он не пустой
                    DateTime date_and_time = reader.GetDateTime(2); //Считать дату и время
                    int rating = reader.GetInt32(3); //Считать оценку
                    int user_code = reader.GetInt32(4); //Считать код пользователя
                    int product_code = reader.GetInt32(5); //Считать код продукта

                    feedback = new Feedback(id_feedback, comment, date_and_time, rating, user_code, product_code);
                }
                return feedback;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return null;
            }
        }

        public Feedback[] GetByProduct(int product_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectFeedbackSql = "SELECT * FROM feedbacks WHERE product_code = @product_code;"; //Sql запрос получения отзывов для продукта

                using var selectFeedbackCommand = new MySqlCommand(selectFeedbackSql, connection); //Создание команды

                selectFeedbackCommand.Parameters.AddWithValue("@product_code", product_code); //Подстановка кода товара в команду

                using var reader = selectFeedbackCommand.ExecuteReader(); //Выполнение команды

                var feedbacks = new List<Feedback>(); //Список для отзывов
                while (reader.Read())
                {
                    int id_feedback = reader.GetInt32(0); //Считать ID отзыва
                    string comment = null;
                    if (!reader.IsDBNull(1) && reader.GetString(1) != "")
                        comment = reader.GetString(1); //Считать комментарий, если он не пустой
                    DateTime date_and_time = reader.GetDateTime(2); //Считать дату и время
                    int rating = reader.GetInt32(3); //Считать оценку
                    int user_code = reader.GetInt32(4); //Считать код пользователя

                    feedbacks.Add(new Feedback(id_feedback, comment, date_and_time, rating, user_code, product_code)); //Добавить отзыв
                }
                return feedbacks.ToArray();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Feedback[] { };
            }
        }

        public Feedback[] GetByUser(int user_code)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectFeedbackSql = "SELECT * FROM feedbacks WHERE user_code = @user_code;"; //Sql запрос получения отзывов для пользователя

                using var selectFeedbackCommand = new MySqlCommand(selectFeedbackSql, connection); //Создание команды

                selectFeedbackCommand.Parameters.AddWithValue("@user_code", user_code); //Подстановка кода товара в команду

                using var reader = selectFeedbackCommand.ExecuteReader(); //Выполнение команды

                var feedbacks = new List<Feedback>(); //Список для отзывов
                while (reader.Read())
                {
                    int id_feedback = reader.GetInt32(0); //Считать ID отзыва
                    string comment = null;
                    if (reader.IsDBNull(1) && reader.GetString(1) != "")
                        comment = reader.GetString(1); //Считать комментарий, если он не пустой
                    DateTime date_and_time = reader.GetDateTime(2); //Считать дату и время
                    int rating = reader.GetInt32(3); //Считать оценку
                    int product_code = reader.GetInt32(5); //Считать код товара

                    feedbacks.Add(new Feedback(id_feedback, comment, date_and_time, rating, user_code, product_code)); //Добавить отзыв
                }
                return feedbacks.ToArray();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return new Feedback[] { };
            }
        }
    }
}
