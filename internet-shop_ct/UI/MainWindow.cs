using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using internet_shop_ct.internet_shop_ct.UI;

namespace internet_shop_ct
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            setProductsTable(); //Установить таблицу товаров
            setCategoriesTable(); //Установить таблицу категорий
        }

        private void setProductsTable()
        {
            IProductsRepository<Product> repository = new ProductsRepository(); //Создать репозиторий для работы с БД

            Product[] products = repository.GetAll(); // Получить все товары

            foreach (Product product in products)
            { //Для каждого товара
                this.ProductsTable.Rows.Add(product.Product_code,product.Name, product.Price); //Добавить в таблицу
            }
        }

        private void ProductsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int buyIndex = this.ProductBuy.Index; //Индекс колонки с кнопкой покупки
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(ProductsTable[0, rowIndex].Value);
            if (e.ColumnIndex != buyIndex)
            {//Индекс не равен индексу покупки
                using ProductWindow productWindow = new ProductWindow(id);
                productWindow.ShowDialog(); //Отобразить окно товара
            }
        }

        private void setCategoriesTable()
        {
            ICategoriesRepository<Category> categoriesRepository = new CategoriesRepository(); //Репозиторий категорий

            Category[] categories = categoriesRepository.GetAll(); //Все категории

            foreach (Category category in categories)
            { //Для каждой категории
                this.CategoriesTable.Rows.Add(category.Name); //Добавить в таблицу
            }

            this.CategoriesTable[0, 0].Selected = true; //Выбрать 1-ую категорию
        }

        private void CategoriesTable_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CategoriesProducts.Rows.Clear(); //Очистить таблицу
            ICategoriesRepository<Category> categoriesRepository = new CategoriesRepository(); //Репозиторий категорий

            Category category = new Category((string)this.CategoriesTable.SelectedRows[0].Cells[0].Value); //Текущая категория
            Product[] products = categoriesRepository.GetProductsFromCategory(category); //Продукты в данной категории

            foreach (Product product in products)
            {//Для каждого товара
                this.CategoriesProducts.Rows.Add(product.Product_code, product.Name, product.Price); //Добавить в таблицу
            }
        }

        private void CategoriesProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; //Выбранный товар
            int id = Convert.ToInt32(CategoriesProducts[0, rowIndex].Value);
            using ProductWindow productWindow = new ProductWindow(id);
            productWindow.ShowDialog(); //Отобразить окно товара
        }
    }
}