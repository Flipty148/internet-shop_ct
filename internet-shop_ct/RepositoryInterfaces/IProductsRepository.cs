namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IProductsRepository<T>
    {
        T[] GetAll(); //Получить все товары

        T GetByProductCode(int product_code); //Получить товар по его коду

        T Add(T newProduct); //Добавить товар

        T Update(T existingProduct); //Обновить данные товара

        void Delete(T existingProduct); //Удалить товар

    }
}
