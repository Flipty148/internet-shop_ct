namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IPromosRepository<T>
    {
        T GetById(T existingPromo);

        internet_shop_ct.Models.Product[] GetProductsFromPromo(T existingPromo);

        T[] GetCurrentPromos();
    }
}
