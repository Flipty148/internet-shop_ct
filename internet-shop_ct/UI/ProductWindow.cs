using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using internet_shop_ct.internet_shop_ct.UI;

namespace internet_shop_ct.internet_shop_ct.UI
{
    public partial class ProductWindow : Form
    {
        private Product CurProduct;
        public ProductWindow(int product_code)
        {
            InitializeComponent();
            ProductsRepository productsRepository = new ProductsRepository();
            CurProduct = productsRepository.GetByProductCode(product_code);
        }

        private void ProductWindow_Load(object sender, EventArgs e)
        {
            this.ProductName.Text = CurProduct.Name; //Установить имя текущего товара
            this.Price.Text = CurProduct.Price.ToString() + "р."; //Установить цену текущего товара
            SetFeedbacksTable(); //Установить отзывы
            SetCharacteristicsTable(); //Установить характеристики
        }

        private void SetFeedbacksTable()
        {
            IFeedbacksRepository<Feedback> feedbacksRepository = new FeedbacksRepository(); //Репозиторий отзывов
            IUsersRepository<User> usersRepository = new UsersRepository(); //Репозиторий пользователей
            float avgRating = feedbacksRepository.AvgRating(CurProduct.Product_code); //Получит среднюю оценку
            this.Rating.Text = avgRating.ToString() + "★"; //Установить среднюю оценку

            Feedback[] feedbacks = feedbacksRepository.GetByProduct(CurProduct.Product_code); //Получить все отзывы для доннго товара

            foreach (Feedback feedback in feedbacks)
            { //Для каждого отзыва
                User user = usersRepository.GetByUserCode(feedback.User_code); //Получить пользователя, оставившего отзыв
                this.FeedbackTable.Rows.Add(user.Name, feedback.Rating, feedback.Comment, DateOnly.FromDateTime(feedback.Date_and_time)); //Установить отзыв в таблицу
            }
        }

        private void SetCharacteristicsTable()
        {
            ICharacteristicsRepository<Characteristic> characteristicsRepository = new CharacteristicsRepository(); //Репозиторий характеристик
            Characteristic[] characteristics = characteristicsRepository.GetAllByProduct(CurProduct); //Все характеристики продукта

            foreach (Characteristic characteristic in characteristics)
            {// Для каждой характеристики
                this.CharacteristicsTable.Rows.Add(characteristic.Name, characteristic.Description, characteristic.Value); //Добавить в таблицу
            }
        }
    }
}
