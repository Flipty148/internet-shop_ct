using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using internet_shop_ct.internet_shop_ct.UI;
using internet_shop_ct.UI;

namespace internet_shop_ct
{
    public partial class MainWindow : Form
    {
        private User CurUser = null;

        public void setUser(User user)
        {
            CurUser = user;
        }
        public MainWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            setProductsTable(); //���������� ������� �������
            setCategoriesTable(); //���������� ������� ���������
            setPromosTable(); //���������� ������� �����
        }

        private void setProductsTable()
        {
            IProductsRepository<Product> repository = new ProductsRepository(); //������� ����������� ��� ������ � ��

            Product[] products = repository.GetAll(); // �������� ��� ������

            foreach (Product product in products)
            { //��� ������� ������
                this.ProductsTable.Rows.Add(product.Product_code,product.Name, product.Price); //�������� � �������
            }
        }

        private void ProductsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int buyIndex = this.ProductBuy.Index; //������ ������� � ������� �������
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(ProductsTable[0, rowIndex].Value);
            if (e.ColumnIndex != buyIndex)
            {//������ �� ����� ������� �������
                using ProductWindow productWindow = new ProductWindow(id);
                productWindow.ShowDialog(); //���������� ���� ������
            }
        }

        private void setCategoriesTable()
        {
            ICategoriesRepository<Category> categoriesRepository = new CategoriesRepository(); //����������� ���������

            Category[] categories = categoriesRepository.GetAll(); //��� ���������

            foreach (Category category in categories)
            { //��� ������ ���������
                this.CategoriesTable.Rows.Add(category.Name); //�������� � �������
            }

            this.CategoriesTable[0, 0].Selected = true; //������� 1-�� ���������
        }

        private void CategoriesTable_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CategoriesProducts.Rows.Clear(); //�������� �������
            ICategoriesRepository<Category> categoriesRepository = new CategoriesRepository(); //����������� ���������

            Category category = new Category((string)this.CategoriesTable.SelectedRows[0].Cells[0].Value); //������� ���������
            Product[] products = categoriesRepository.GetProductsFromCategory(category); //�������� � ������ ���������

            foreach (Product product in products)
            {//��� ������� ������
                this.CategoriesProducts.Rows.Add(product.Product_code, product.Name, product.Price); //�������� � �������
            }
        }

        private void CategoriesProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; //��������� �����
            int id = Convert.ToInt32(CategoriesProducts[0, rowIndex].Value);
            using ProductWindow productWindow = new ProductWindow(id);
            productWindow.ShowDialog(); //���������� ���� ������
        }

        private void setPromosTable()
        {
            IPromosRepository<Promo> promosRepository = new PromosRepository(); //����������� �����

            Promo[] promos = promosRepository.GetCurrentPromos(); //��������� ������� �����

            foreach (Promo promo in promos)
            { //��� ������ �����
                this.PromoTable.Rows.Add(promo.Id_promos, promo.Name, promo.Start_date, promo.End_date, promo.Promo_percent*100 + "%"); //�������� � �������
            }
        }

        private void PromoTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; //��������� �����
            int id = Convert.ToInt32(PromoTable[0, rowIndex].Value);
            using PromoWindow productWindow = new PromoWindow(id);
            productWindow.ShowDialog(); //���������� ���� �����
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            using LoginWindow loginWindow = new LoginWindow(this);
            loginWindow.ShowDialog();
            
            if (CurUser != null)
            { //���� ��������
                this.Login.Text = CurUser.Name;
            }
        }
    }
}