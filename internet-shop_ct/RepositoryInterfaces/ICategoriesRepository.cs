namespace internet_shop_ct.RepositoryInterfaces
{
    public interface ICategoriesRepository<T>
    {
        T[] GetAll(); //Получить все категории

        internet_shop_ct.Models.Product[] GetProductsFromCategory(T existingCategory); //Получить все продукты из данной категории

        T GetById(int id_category); //Получить категорию по её id
    }
}
