namespace internet_shop_ct.Models
{
    public class Order
    {
        public enum PaymentMethod { ONLINE, CASH, CARD };
        public struct ProductInOrder
        {
            public Product Product; //Товар
            public int Count; //Количество в заказе
        }

        public struct OrderPickUpPoint 
        {
            public int id; //ID пункта выдачи
            public string name; //Название пункта выдачи
            public string address; //Адрес пункта выдачи
        };

        public List<ProductInOrder> ProductsInOrder { get; private set; }
        public int Order_code { get; private set; } //Код заказа

        public DateTime Date_and_time { get; private set; } //Дата и время заказа

        public PaymentMethod Payment_method { get; private set; } //Способ оплаты

        public OrderPickUpPoint Order_pick_up_point { get; private set; } //Пункт получения заказа

        public Order(int order_code, DateTime date_and_time, PaymentMethod payment_method, OrderPickUpPoint order_pick_up_point)
        {
            Order_code = order_code;
            Date_and_time = date_and_time;
            Payment_method = payment_method;
            Order_pick_up_point = order_pick_up_point;
        }

        public Order(DateTime date_and_time, PaymentMethod payment_method, OrderPickUpPoint order_pick_up_point)
        {
            Date_and_time = date_and_time;
            Payment_method = payment_method;
            Order_pick_up_point = order_pick_up_point;
        }

        public Order(PaymentMethod payment_method, OrderPickUpPoint order_pick_up_point)
        {
            Date_and_time = DateTime.Now;
            Payment_method = payment_method;
            Order_pick_up_point = order_pick_up_point;
        }

        public Order(PaymentMethod payment_method, OrderPickUpPoint order_pick_up_point, List<ProductInOrder> productInOrders)
        {
            Date_and_time = DateTime.Now;
            Payment_method = payment_method;
            Order_pick_up_point = order_pick_up_point;
            ProductsInOrder = productInOrders;
        }

        public Order(Order otherOrder)
        {
            Order_code = otherOrder.Order_code;
            Date_and_time = otherOrder.Date_and_time;
            Payment_method = otherOrder.Payment_method;
            Order_pick_up_point = otherOrder.Order_pick_up_point;
            ProductsInOrder = otherOrder.ProductsInOrder;
        }

        public void appendProductToOrder(ProductInOrder productInOrder)
        {
            ProductsInOrder.Append(productInOrder);
        }

        public void removeProductFromOrder(ProductInOrder productInOrder)
        {
            ProductsInOrder.Remove(productInOrder);
        }
    }
}
