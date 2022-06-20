using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;

namespace internet_shop_ct.UI
{
    public partial class OrderBasketWindow : Form
    {
        private Order CurOrder;
        private Order.OrderPickUpPoint[] pickUpPoints;
        MainWindow Main;
        public OrderBasketWindow(Order order, MainWindow main)
        {
            InitializeComponent();
            CurOrder = order;
            Main = main;
        }

        private void OrderBasketWindow_Load(object sender, EventArgs e)
        {
            foreach (Order.ProductInOrder productInOrder in CurOrder.ProductsInOrder)
            {//Для каждого товара в корзине
                int productCode = productInOrder.Product.Product_code; //Код товара
                string name = productInOrder.Product.Name; //Название товара
                int price = productInOrder.Product.Price; //Цена товара
                int count = productInOrder.Count; //Количество товара
                ProductsTable.Rows.Add(productCode, name, price, '-',count); //Добавление в таблицу
            }
            ChangeTotalPrice();

            SetPickUpPointsBox(); //установить пункты выдачи
            PickUpPointBox.SelectedIndex = 0; //установить пункт выдачи по умолчанию
            PaymentMethodBox.SelectedIndex = 0; //установить способ оплаты по умолчанию
        }
        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int minusIndex = Minus.Index; //Индекс уменьшения количества
            int plusIndex = Plus.Index; //Индекс увеличения количества
            int deleteIndex = Delete.Index; //Индекс удаления товара из заказа
            int productCodeIndex = ProductCode.Index; //Индекс кода товара
            int productCode = (int)ProductsTable[productCodeIndex, e.RowIndex].Value; //Код товара

            if (e.ColumnIndex == deleteIndex)
            {
                DeleteProduct(productCode, e.RowIndex);
                ChangeTotalPrice();
            }
            if (e.ColumnIndex == plusIndex)
            {
                GrowCount(productCode, e.RowIndex);
                ChangeTotalPrice();
            }
            if (e.ColumnIndex == minusIndex)
            {
                ReduceCount(productCode, e.RowIndex);
                ChangeTotalPrice();
            }
        }

        private void ReduceCount(int product_code, int rowIndex)
        {
            //Найти индекс товара в предполагаемом заказе
            int i = 0;
            bool isFind = false;
            while (i < CurOrder.ProductsInOrder.Count && !isFind)
            {
                if (CurOrder.ProductsInOrder[i].Product.Product_code == product_code)
                    isFind = true;
                else
                    i++;
            }

            if (CurOrder.ProductsInOrder[i].Count <= 1)
            {
                DeleteProduct(product_code, rowIndex);
            }
            else
            {
                CurOrder.ProductsInOrder[i].Count--; //Уменьшить количество

                int countIndex = Count.Index; //Индекс количества в таблице
                ProductsTable[countIndex, rowIndex].Value = CurOrder.ProductsInOrder[i].Count; //Изменение количества в таблице

            }
        }

        private void GrowCount(int product_code, int rowIndex)
        {
            //Найти индекс товара в предполагаемом заказе
            int i = 0;
            bool isFind = false;
            while (i < CurOrder.ProductsInOrder.Count && !isFind)
            {
                if (CurOrder.ProductsInOrder[i].Product.Product_code == product_code)
                    isFind = true;
                else
                    i++;
            }

            CurOrder.ProductsInOrder[i].Count++; //Увеличить количество

            int countIndex = Count.Index; //Индекс количества в таблице
            ProductsTable[countIndex, rowIndex].Value = CurOrder.ProductsInOrder[i].Count; //Изменение количества в таблице
        }

        private void DeleteProduct(int product_code, int rowIndex)
        {
            
            //Найти индекс товара в предполагаемом заказе
            int i = 0; 
            bool isFind = false;
            while (i< CurOrder.ProductsInOrder.Count && !isFind)
            {
                if (CurOrder.ProductsInOrder[i].Product.Product_code == product_code)
                    isFind = true;
                else
                    i++;
            }
         
            Order.ProductInOrder productInOrder = CurOrder.ProductsInOrder[i];

            string message = $"Вы действительно хотите удалить товар {productInOrder.Product.Name} из корзины?";
            string caption = "Подтверждение";

            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CurOrder.removeProductFromOrder(productInOrder); //Удалить товар
                ProductsTable.Rows.RemoveAt(rowIndex); //Удалить товар из таблицы
            }
        }

        private void ChangeTotalPrice()
        {
            TotalPrice.Text = "Итого: " + TotalCost();
        }
        private int TotalCost()
        {
            int total = 0; //Общая стоимость

            foreach(Order.ProductInOrder productInOrder in CurOrder.ProductsInOrder)
            {//Для каждого товара в корзине
                total += productInOrder.Product.Price * productInOrder.Count; //Прибавить стоимость к общей
            }

            return total;
        }

        private void SetPickUpPointsBox()
        {
            IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //репозиторий заказов

            if(pickUpPoints == null)
            { //Список пунктов выдачи не получен
                pickUpPoints = ordersRepository.GetAllPickUpPoints(); //Получить все пункты выдачи
            }

            foreach (Order.OrderPickUpPoint orderPickUpPoint in pickUpPoints)
            { //Для каждого пункта выдачи
                PickUpPointBox.Items.Add(orderPickUpPoint.name + $" ({orderPickUpPoint.address})"); //Добавить в comboboxs
            }
        }

        private void OrderButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (CurOrder.ProductsInOrder.Count == 0)
            { //В заказе нет товаров
                string message = "Невозможно создать пустой заказ";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Order.PaymentMethod paymentMethod = (Order.PaymentMethod)PaymentMethodBox.SelectedIndex;
            Order.OrderPickUpPoint orderPickUpPoint = pickUpPoints[PickUpPointBox.SelectedIndex];
            Order order = new Order(paymentMethod, orderPickUpPoint, CurOrder.ProductsInOrder);

            IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //РЕпозиторий заказов

            try
            {
                ordersRepository.Add(order, Main.getCurUserCode()); //Добавить заказ в БД

                string message = "Заказ успешно создан";
                string caption = "Заказ";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); //Закрыть окно корзины
                Main.ClearPossibleOrder();
            }
            catch (RepositoryException)
            {
                string message = "Заказ не удалось создать!";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
