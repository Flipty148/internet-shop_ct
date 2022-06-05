namespace internet_shop_ct.Models
{
    public class Category
    {
        public int Id_Categories { get; private set; }

        public string Name { get; private set; }

        public Category(int id_categories, string name)
        {
            Id_Categories = id_categories;
            Name = name;
        }

        public Category(string name)
        {
            Name = name;
        }
    }
}
