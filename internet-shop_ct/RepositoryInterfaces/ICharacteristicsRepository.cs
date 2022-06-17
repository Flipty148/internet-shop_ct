namespace internet_shop_ct.RepositoryInterfaces
{
    public interface ICharacteristicsRepository<T>
    {
        string[] GetValuesById(int id); //Получить все значения характеристики по её ID

        T[] GetAllByProduct(Models.Product existingProduct); //Получить все характеристики товара
    }
}
