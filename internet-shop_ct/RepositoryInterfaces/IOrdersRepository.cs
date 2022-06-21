namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IOrdersRepository<T>
    {
        T Add(T newOrder, int userCode); //Добавление заказа

        T Update(T existingOrder); //Обновление заказа (только пункта выдачи)

        void Delete(T existingOrder); //Удаление заказа

        T GetProductsByOrder(T existingOrder); //Все товары в заказе

        Models.User GetUserByOrder(T existingOrder); //Пользователь по заказу

        T[] GetOrdersByUser(int user_code); //Получить все заказы пользователя

        T GetByOrderCode(int order_code); //Получить по коду заказа

        Models.Order.OrderPickUpPoint[] GetAllPickUpPoints();  //Получить все пункты выдачи

        int TotalOrderCost(int order_code); //Стоимотсь заказа
    }
}
