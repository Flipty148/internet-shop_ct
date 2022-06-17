namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IPromosRepository<T>
    {
        T GetById(int id_promo); //Получит акцию по её id

        Models.Product[] GetProductsFromPromo(T existingPromo); //Получить продукты, участвующие в акции

        T[] GetCurrentPromos(); //Получить текущие акции
    }
}
