namespace internet_shop_ct.Models
{
    public class User
    {
        public int User_code { get; private set; } //Код пользователя

        public decimal Phone_number { get; private set; } //Номер телефона

        public string Name { get; private set; } //Имя

        public string Password { get; private set; } //Пароль

        public DateOnly Registration_date { get; private set; } //Дата регистрации

        public User(int user_code, decimal phone_number, string name, string password, DateOnly registration_date)
        {
            User_code = user_code;
            Phone_number = phone_number;
            Name = name;
            Password = password;
            Registration_date = registration_date;
        }

        public User(decimal phone_number, string name, string password)
        {
            Phone_number = phone_number;
            Name = name;
            Password = password;
            Registration_date = DateOnly.FromDateTime(DateTime.Today);
        }
    }
}
