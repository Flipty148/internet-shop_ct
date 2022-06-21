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
        protected Order possibleOrder = new();
        private AccountWindow accountWindow = null;

        public void setUser(User user)
        {
            CurUser = user;
        }

        public void clearAccountWindow()
        {
            accountWindow = null;
        }

        public void ClearPossibleOrder()
        {
            possibleOrder = new();
        }

        public MainWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            setProductsTable(); //Установить таблицу товаров
            setCategoriesTable(); //Установить таблицу категорий
            setPromosTable(); //Установить таблицу акций
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
                using ProductWindow productWindow = new ProductWindow(id,this);
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
            using ProductWindow productWindow = new ProductWindow(id,this);
            productWindow.ShowDialog(); //Отобразить окно товара
        }

        private void setPromosTable()
        {
            IPromosRepository<Promo> promosRepository = new PromosRepository(); //Репозиторий акций

            Promo[] promos = promosRepository.GetCurrentPromos(); //Получение текущих акций

            foreach (Promo promo in promos)
            { //Для каждой акции
                this.PromoTable.Rows.Add(promo.Id_promos, promo.Name, promo.Start_date, promo.End_date, promo.Promo_percent*100 + "%"); //Добавить в таблицу
            }
        }

        private void PromoTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; //Выбранная акция
            int id = Convert.ToInt32(PromoTable[0, rowIndex].Value);
            using PromoWindow productWindow = new PromoWindow(id);
            productWindow.ShowDialog(); //Отобразить окно акции
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (Login.Text == "Войти")
            { //Вход не выыполнен
                using LoginWindow loginWindow = new LoginWindow(this);
                loginWindow.ShowDialog();

                if (CurUser != null)
                { //Вход выполнен
                    this.Login.Text = CurUser.Name;
                }
            }
            else
            { //Вход выполнен
                //Показать окно учётной записи
                Hide();
                if (accountWindow == null)
                    accountWindow = new AccountWindow(this);
                accountWindow.ShowDialog();
                if (CurUser == null)
                {
                    Login.Text = "Войти";
                    possibleOrder = new();
                }
                else
                    Login.Text = CurUser.Name;
            }
        }

        private void Basket_MouseClick(object sender, MouseEventArgs e)
        {
            if (CurUser == null)
            { //Вход не выполнен
                string message = "Войдите в аккаунт";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { //Вход выполнен
                using OrderBasketWindow orderBasketWindow = new OrderBasketWindow(possibleOrder, this);
                orderBasketWindow.ShowDialog();
            }
        }

        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productBuyIndex = ProductBuy.Index; //Индекс колонки с кнопкой купить
            int productCodeIndex = ProductCode.Index; //Индекс колонки кода товара
            int productCode = (int)ProductsTable[productCodeIndex, e.RowIndex].Value; //Код товара
            if (e.ColumnIndex == productBuyIndex)
            { //Нажата кнопка купить
                appendProductToBascket(productCode);
                ProductsTable.ClearSelection();
            }
        }

        public void appendProductToBascket(int productCode)
        {
            if (CurUser == null)
            {//Вход не выполнен
                string message = "Войдите в аккаунт чтобы добавить товар в корзину";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {//Вход выполнен
             //Проверить, содержится ли товар в корзине
                bool isContainsInBasket = false;
                if (possibleOrder.ProductsInOrder.Count != 0)
                {
                    foreach (Order.ProductInOrder productInOrder in possibleOrder.ProductsInOrder)
                    {
                        if (productInOrder.Product.Product_code == productCode)
                        {
                            isContainsInBasket = true;
                            break;
                        }
                    }
                }

                if (isContainsInBasket == true)
                { //Если товар содержиться в корзине
                    string message = "Товар уже содержиться в корзине";
                    string caption = "Внимание";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { //Если товар не содержиться в корзине
                    IProductsRepository<Product> productsRepository = new ProductsRepository();
                    Order.ProductInOrder productInOrder = new Order.ProductInOrder { Product = productsRepository.GetByProductCode(productCode), Count = 1 };
                    possibleOrder.appendProductToOrder(productInOrder);
                }
            }
        }

        public int getCurUserCode()
        {
            return CurUser.User_code;
        }
    }
}