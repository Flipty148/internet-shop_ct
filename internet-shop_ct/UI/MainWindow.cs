using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;

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
            IProductsRepository<Product> repository = new ProductsRepository(); //������� ����������� ��� ������ � ��

            Product[] products = repository.GetAll(); // �������� ��� ������

            foreach (Product product in products)
            { //��� ������� ������
                this.ProductsTable.Rows.Add(product.Name, product.Price); //�������� � �������
            }
        }
    }
}