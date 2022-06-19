using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using internet_shop_ct.internet_shop_ct.UI;

namespace internet_shop_ct.UI
{
    public partial class PromoWindow : Form
    {
        private Promo CurPromo;
        public PromoWindow(int id)
        {
            InitializeComponent();
            IPromosRepository<Promo> promosRepository = new PromosRepository();
            CurPromo = promosRepository.GetById(id);
        }

        private void PromoWindow_Load(object sender, EventArgs e)
        {
            this.PromoName.Text = CurPromo.Name; //Установить название акции
            this.Date.Text = CurPromo.Start_date + " - " + CurPromo.End_date; //Установить сроки акций
            this.Percent.Text = CurPromo.Promo_percent * 100 + "%"; //Установить размер акции
            this.ConditionsText.Text = CurPromo.Promo_conditions; //Установить условия акции
            this.DescriptionText.Text = CurPromo.Description; //Установить описание акции 
            SetProductsTable(); //Установить товары
        }

        private void SetProductsTable()
        {
            IPromosRepository<Promo> promosRepository = new PromosRepository(); //Репозиторий акций

            Product[] products = promosRepository.GetProductsFromPromo(CurPromo); //Товары из акции

            foreach (Product product in products)
            { //Для каждого товара
                this.ProductsTable.Rows.Add(product.Name, product.Price); //Добавить в таблицу
            }
        }
    }
}
