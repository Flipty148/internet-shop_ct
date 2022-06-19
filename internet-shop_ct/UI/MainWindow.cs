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
            setProductsTable();
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
    }
}