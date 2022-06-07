namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IFeedbacksRepository<T>
    {
        T GetById(int id); //Получить по Id

        T[] GetByUser(int user_code); //Получить все отзывы пользователя

        T[] GetByProduct(int product_code); //Получить все отзывы для товара

        float AvgRating(int product_code); //Получить среднюю оценку для продукта
    }
}
