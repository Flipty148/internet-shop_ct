namespace internet_shop_ct.RepositoryInterfaces
{
    public interface ICharacteristicsRepository<T>
    {
        string[] GetValuesById(int id); //Получить все значения характеристики по её ID

        T[] GetAllByProduct(internet_shop_ct.Models.Product existingProduct); //Получить все характеристики товара
    }
}
