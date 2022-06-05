namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IPromosRepository<T>
    {
        T GetById(int id_promo); //Получит акцию по её id

        internet_shop_ct.Models.Product[] GetProductsFromPromo(T existingPromo); //Получить продукты, участвующие в акции

        T[] GetCurrentPromos(); //Получить текущие акции
    }
}
