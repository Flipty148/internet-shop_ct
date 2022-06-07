namespace internet_shop_ct.Models
{
    public class Feedback
    {
        public int Id { get; private set; } //ID отзыва

        public string? Comment { get; private set; } //Комментарий

        public DateTime Date_and_time { get; private set; } //Дата и время отзыва

        public int Rating { get; private set; } //Оценка

        public int User_code { get; private set; } //Код пользователя

        public int Product_code { get; private set; } //код товара

        public Feedback(int id, string comment, DateTime date_and_time, int rating, int user_code, int product_code)
        {
            Id = id;
            Comment = comment;
            Date_and_time = date_and_time;
            Rating = rating;
            User_code = user_code;
            Product_code = product_code;
        }

        public Feedback(string comment, DateTime date_and_time, int rating, int user_code, int product_code)
        {
            Comment = comment;
            Date_and_time = date_and_time;
            Rating = rating;
            User_code = user_code;
            Product_code = product_code;
        }

        public Feedback(DateTime date_and_time, int rating, int user_code, int product_code)
        {
            Date_and_time = date_and_time;
            Rating = rating;
            User_code = user_code;
            Product_code = product_code;
        }

        public Feedback(int rating, int user_code, int product_code)
        {
            Date_and_time = DateTime.Now;
            Rating = rating;
            User_code = user_code;
            Product_code = product_code;
        }
    }
}
