using internet_shop_ct.Models;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.SqlDbConnect;
using MySql.Data.MySqlClient;

namespace internet_shop_ct.Repositories
{
    public class UsersRepository : IUsersRepository<User>
    {
        private const string DateFormat = "yyyy-MM-dd";

        public User Add(User newUser)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var insertUserSql = @"INSERT INTO users (phone_number, name, password, registration_date)
                                  VALUES (@phone_number, @name, @password, @registration_date);"; //Sql запрос добавления пользователя

                using var insertCommand = new MySqlCommand(insertUserSql, connection); //Создание команды

                insertCommand.Parameters.AddWithValue("@phone_number", newUser.Phone_number); //Подстановка номера телефона в команду
                insertCommand.Parameters.AddWithValue("@name", newUser.Name); //Подстановка имени в команду
                insertCommand.Parameters.AddWithValue("@password", newUser.Password); //Подстановка пароля в команду
                insertCommand.Parameters.AddWithValue("@registration_date", newUser.Registration_date.ToString(DateFormat)); //Подстановка даты регистрации в команду

                insertCommand.ExecuteNonQuery(); //Выполнение команды
                int id = Convert.ToInt32(insertCommand.LastInsertedId); //Получение кода пользователя после добавления

                User returnedUser = new User(id, newUser.Phone_number, newUser.Name, newUser.Password, newUser.Registration_date);

                return returnedUser;
            }
            catch (MySqlException ex)
            {
                throw new RepositoryException(ex.Number, ex.Message);
                return null;
            }
        }

        public int CountRegistratedDays(User existingUser)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var countDaysSql = "SELECT datediff(curdate(), u.registration_date) FROM users AS u WHERE user_code = @user_code;"; //Sql запрос количества зарегистрированных дней

                using var countDaysCommand = new MySqlCommand(countDaysSql, connection); //Создание команды

                countDaysCommand.Parameters.AddWithValue("@user_code", existingUser.User_code);  //Подстановка кода пользователя в команду

                using var reader = countDaysCommand.ExecuteReader(); //Выполнение команды

                int countDays = 0; //Количество зарегистрированных дней
                if (reader.Read())
                {
                    countDays = reader.GetInt32(0);
                }

                return countDays;
            }
            catch (MySqlException)
            {
                return 0;
            }
        }

        public void Delete(User existingUser)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var deleteUserSql = "DELETE FROM users WHERE user_code = @user_code;"; //Sqql запрос удаления пользователя

                using var deleteCommand = new MySqlCommand(deleteUserSql, connection); //Создание команды

                deleteCommand.Parameters.AddWithValue("@user_code", existingUser.User_code); //Подстановка кода пользователя в команду
                
                deleteCommand.ExecuteNonQuery(); //Выполнение команды
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
            }
        }

        public User GetByLogin(decimal phone_number, string password)
        {
            User user = null;
            try
            {
                using var connection = SqlDbConnection.GetDbConnection();

                connection.Open();

                var selectUserSql = "SELECT * FROM users WHERE phone_number = @phone_number and password = @password;";

                using var selectCommand = new MySqlCommand(selectUserSql, connection);

                selectCommand.Parameters.AddWithValue("@phone_number", phone_number);
                selectCommand.Parameters.AddWithValue("@password", password);

                using var reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    int user_code = reader.GetInt32(0);
                    decimal phone = reader.GetDecimal(1);
                    string name = reader.GetString(2);
                    string pass = reader.GetString(3);
                    DateOnly date = DateOnly.FromDateTime(reader.GetDateTime(4));

                    user = new User(user_code, phone, name, pass, date);
                }

                return user;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return user;
            }
        }

        public User GetByUserCode(int user_code)
        {
            User user = null;
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var selectUserSql = "SELECT * FROM users WHERE user_code = @user_code"; //Sql запрос получения пользователя по его коду

                using var selectCommand = new MySqlCommand(selectUserSql, connection); //Создание команды

                selectCommand.Parameters.AddWithValue("@user_code", user_code); //Подстановка кода пользователя в команду

                using var reader = selectCommand.ExecuteReader(); //Выполнение команды

                
                if (reader.Read())
                {
                    int id = reader.GetInt32(0); //Получение кода пользователя
                    decimal phone_number = reader.GetDecimal(1); //получения номера телефона
                    string name = reader.GetString(2); //Получение имени
                    string password = reader.GetString(3); //Получение пароля
                    DateOnly registration_date = DateOnly.FromDateTime(reader.GetDateTime(4)); //Получение даты регистрации

                    user = new User(id, phone_number, name, password, registration_date); //Создание пользователя
                }

                return user;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return user;
            }
        }

        public User Update(User existingUser)
        {
            try
            {
                using var connection = SqlDbConnection.GetDbConnection(); //Соединение

                connection.Open(); //Открытие соединения

                var updateUserSql = @"UPDATE users
                                  SET phone_number = @phone_number, name = @name, password = @password
                                  WHERE user_code = @user_code;"; //Sql запрос обновления пользователя

                using var updateCommand = new MySqlCommand(updateUserSql, connection); //Создание команды

                updateCommand.Parameters.AddWithValue("@phone_number", existingUser.Phone_number); //Подстановка обновлённого номера телефона в команду
                updateCommand.Parameters.AddWithValue("@name", existingUser.Name); //Подстановка обновлённого имени в команду
                updateCommand.Parameters.AddWithValue("@password", existingUser.Password); //Подстановка обновлённого пароля в команду
                updateCommand.Parameters.AddWithValue("@user_code", existingUser.User_code); //Подстановка кода пользователя в команду

                updateCommand.ExecuteNonQuery(); //Выполнение команды

                return existingUser;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ошибка базы данных: {ex.Message}");
                return existingUser;
            }
        }
    }
}
