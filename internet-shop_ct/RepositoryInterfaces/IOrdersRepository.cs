namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IOrdersRepository<T>
    {
        struct ProductInOrder
        {
            public Models.Product Product; //Товар
            public int Count; //Количество в заказе
        }
        T Add(T newOrder, ProductInOrder[] products, int userCode); //Добавление заказа

        T Update(T existingOrder); //Обновление заказа (только пункта выдачи)

        void Delete(T existingOrder); //Удаление заказа

        Models.Product[] GetProductsByOrder(T existingOrder); //Все товары в заказе

        Models.User GetUserByOrder(T existingOrder); //Пользователь по заказу

        T[] GetOrdersByUser(int user_code); //Получить все заказы пользователя

        T GetByOrderCode(int order_code); //Получить по коду заказа
    }
}
