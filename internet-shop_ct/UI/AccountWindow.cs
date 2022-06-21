using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using System.Text.RegularExpressions;
using System.Text;

namespace internet_shop_ct.UI
{
    public partial class AccountWindow : Form
    {
        private Order.OrderPickUpPoint[] pickUpPoints;

        private MainWindow Main;
        private User CurUser;
        public AccountWindow(MainWindow main)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            Main = main;
            int userCode = Main.getCurUserCode();
            IUsersRepository<User> usersRepository = new UsersRepository();
            CurUser = usersRepository.GetByUserCode(userCode);
        }

        private void AccountWindow_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            UserName.Text = CurUser.Name; //Установить имя пользователя
            IUsersRepository<User> usersRepository = new UsersRepository();
            CountDays.Text = usersRepository.CountRegistratedDays(CurUser) + " день"; //Установить количество зарегистрированных дней
            RegisterDate.Text = CurUser.Registration_date.ToString(); //Установить дату регистрации
            UserNameText.Text = CurUser.Name; //Установитть имя
            PhoneNumberText.Text = "+7" + CurUser.Phone_number; //Установить номер телефона
            PasswordText.Text = CurUser.Password; //Установка пароля
            SetOrders(); //Установка заказов
            SetFeedbacks(); //Установка озывов

        }

        private void SetOrders()
        {
            OrderTable.Rows.Clear();
            IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //Репозиторий заказов
            Order[] orders = ordersRepository.GetOrdersByUser(CurUser.User_code); //Все заказы пользователя
            SetPickUpPointsBox(); //Установить все пункты выдачи

            foreach (Order order in orders)
            {//Для каждого заказа
                int number = order.Order_code; //Номер заказа
                DateTime dateTime = order.Date_and_time; //Дата и время заказа
                Order.OrderPickUpPoint orderPickUpPoint = order.Order_pick_up_point; //Пункт выдачи заказов
                Order.PaymentMethod paymentMethod = order.Payment_method; //Способ оплаты
                string payment = null;
                switch (paymentMethod)
                {
                    case Order.PaymentMethod.ONLINE:
                        payment = "Онлайн";
                        break;
                    case Order.PaymentMethod.CASH:
                        payment = "Наличными";
                        break;
                    case Order.PaymentMethod.CARD:
                        payment = "Картой";
                        break;
                }
                int total = ordersRepository.TotalOrderCost(order.Order_code); //Стоимость заказа


                OrderTable.Rows.Add(number, dateTime, orderPickUpPoint.name + $" ({orderPickUpPoint.address})", payment, total, "Изменить"); //Добавление в таблицу
            }
        }
        private void SetFeedbacks()
        {
            FeedbacksTable.Rows.Clear();
            IFeedbacksRepository<Feedback> feedbacksRepository = new FeedbacksRepository(); //Репозиторий отзывов
            IProductsRepository<Product> productsRepository = new ProductsRepository(); //Репозиторий товаров
            Feedback[] feedbacks = feedbacksRepository.GetByUser(CurUser.User_code); //Все отзывы пользователя

            foreach (Feedback feedback in feedbacks)
            {//Для каждого озыва
                DateTime dateTime = feedback.Date_and_time; //Дата и время
                string product = productsRepository.GetByProductCode(feedback.Product_code).Name; //Название товара
                int raiting = feedback.Rating; //Оценка
                string? comment = feedback.Comment; //Комментарий

                FeedbacksTable.Rows.Add(dateTime, product, raiting, comment); //Добавление в таблицу
            }
        }

        private void SetPickUpPointsBox()
        {
            IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //репозиторий заказов

            if (pickUpPoints == null)
            { //Список пунктов выдачи не получен
                pickUpPoints = ordersRepository.GetAllPickUpPoints(); //Получить все пункты выдачи
            }

            foreach (Order.OrderPickUpPoint orderPickUpPoint in pickUpPoints)
            { //Для каждого пункта выдачи
                PickUpPoint.Items.Add(orderPickUpPoint.name + $" ({orderPickUpPoint.address})"); //Добавить в comboboxs
            }
        }

        private void ExitAccountButton_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "Выйти из учётной записи?";
            string caption = "Выход";
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Main.setUser(null); //Очистить пользователя
                Close(); //Скрыть окно учётной записи
                Main.clearAccountWindow(); //Очистить окно учётной записи
                Main.Show(); //Показать главное окно
            }

        }

        private void OrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int changeIndex = Change.Index; //Индекс изменения
            int removeIndex = RemoveOrder.Index; //Индекс отмены
            int orderCodeIndex = OrderNumber.Index; //Индекс номера заказа
            int PickUpPointIndex = PickUpPoint.Index; //Индекс пункта получения
            int orderCode = (int)OrderTable[orderCodeIndex, e.RowIndex].Value; //Значение кода товара

            if (e.ColumnIndex == removeIndex)
            {
                removeOrder(orderCode, e.RowIndex); //Удаление заказа
            }
            if (e.ColumnIndex == changeIndex)
            { //Изменение пункта выдачи
                if (OrderTable[changeIndex, e.RowIndex].Value == "Изменить")
                {
                    OrderTable[PickUpPointIndex, e.RowIndex].ReadOnly = false;
                    OrderTable[changeIndex, e.RowIndex].Value = "Сохранить";
                }
                else
                {
                    SaveChangeOrder(orderCode, e.RowIndex);
                    OrderTable[PickUpPointIndex, e.RowIndex].ReadOnly = true;
                    OrderTable[changeIndex, e.RowIndex].Value = "Изменить";
                }
                    

            }
        }

        private void SaveChangeOrder(int order_code, int rowIndex)
        {
            
            IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //Репозиторий заказов
            Order order = ordersRepository.GetByOrderCode(order_code); //заказ
            int PickUpPointIndex = PickUpPoint.Index;

            int i=0;
            foreach (Order.OrderPickUpPoint pickUpPoint in pickUpPoints)
            { //Индекс нового пункта выдачи
                if (pickUpPoint.name + $" ({pickUpPoint.address})" != (string)OrderTable[PickUpPointIndex, rowIndex].Value)
                    i++;
                else
                    break;
            }
            Order.OrderPickUpPoint orderPickUpPoint = pickUpPoints[i];
            Order newOrder = new Order(order.Order_code, order.Date_and_time, order.Payment_method, orderPickUpPoint);

            ordersRepository.Update(newOrder); //Обновление заказа
        }
        private void removeOrder(int order_code, int rowIndex)
        {
            string message = "Отменить заказ?";
            string caption = "Заказ";
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { //Подтверждение отмены
                try
                {
                    IOrdersRepository<Order> ordersRepository = new OrdersRepository(); //Репозиторий заказов
                    Order order = ordersRepository.GetByOrderCode(order_code);
                    ordersRepository.Delete(order); //Удаление заказа из БД
                    OrderTable.Rows.RemoveAt(rowIndex); //Удаление строки из таблицы

                    string mess = "Отмена успешна";
                    string capt = "Заказ";
                    MessageBox.Show(mess, capt, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Сообщение об успешной отмене
                }
                catch (RepositoryException)
                {
                    string mess = "Отмена не удалась!";
                    string capt = "Внимание";
                    MessageBox.Show(mess, capt, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void MainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide(); //Скрыть текущее окно
            Main.Show(); //Показать главное
        }

        private void UserNameButton_Click(object sender, EventArgs e)
        {
            if (UserNameText.ReadOnly)
                UserNameText.ReadOnly = false;
        }

        private void PhoneNumberButton_Click(object sender, EventArgs e)
        {
            if (PhoneNumberText.ReadOnly)
                PhoneNumberText.ReadOnly = false;
        }

        private void PasswordConfirmButton_Click(object sender, EventArgs e)
        {
            if (PasswordText.ReadOnly)
            {
                PasswordConfirmLabel.Visible = true;
                PasswordConfirmText.Visible = true;
                PasswordText.ReadOnly = false;
            }
        }

        private void PhoneNumberText_KeyDown(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex(@"^\+7\d{0,10}$");//Регулярное выражение для телефона
            if (e.KeyCode == Keys.Delete)
            {//Проверка номера телефона при delete
                if (PhoneNumberText.SelectionStart >= 0 && PhoneNumberText.Text.Length != PhoneNumberText.SelectionStart && !regex.IsMatch(this.PhoneNumberText.Text.Remove(PhoneNumberText.SelectionStart, 1)))
                    e.Handled = true;
                return;
            }
        }

        private void PhoneNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^\+7\d{0,10}$"); //Регулярное выражение для телефона

            //Проверка номера телефона
            if (e.KeyChar != '\b' && e.KeyChar != ((char)Keys.Delete) && !regex.IsMatch(this.PhoneNumberText.Text.Insert(PhoneNumberText.SelectionStart, e.KeyChar.ToString())))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '\b')
                {
                    if (PhoneNumberText.SelectionStart - 1 >= 0 && !regex.IsMatch(this.PhoneNumberText.Text.Remove(PhoneNumberText.SelectionStart - 1, 1)))
                        e.Handled = true;
                    return;
                }

                e.Handled = false;
            }
        }

        private void UserNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Za-z]{0,45}$|^[А-Яа-я]{0,45}$"); //Регулярное выражение

            if (e.KeyChar != '\b' && !regex.IsMatch(this.UserNameText.Text.Insert(UserNameText.SelectionStart, e.KeyChar.ToString())))
            { //Обработка при добавление символа
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '\b')
                { //Обработка при удалении с помощью backspace
                    if (UserNameText.SelectionStart - 1 >= 0 && !regex.IsMatch(UserNameText.Text.Remove(UserNameText.SelectionStart - 1, 1)))
                        e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
        }

        private void UserNameText_KeyDown(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Za-z]{0,45}$|^[А-Яа-я]{0,45}$"); //Регулярное выражение
            if (e.KeyCode == Keys.Delete)
            { //Обработка при удалении с помощью backspace
                if (UserNameText.SelectionStart >= 0 && UserNameText.Text.Length != UserNameText.SelectionStart && !regex.IsMatch(UserNameText.Text.Remove(UserNameText.SelectionStart, 1)))
                    e.Handled = true;
            }
        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            //Замена строки в имени, чтобы первая буква была заглавной, а остальные были строчными
            StringBuilder name = new StringBuilder(UserNameText.Text.ToLower());
            if (!string.IsNullOrEmpty(name.ToString()))
                name[0] = char.ToUpper(UserNameText.Text[0]);
            int cursorPos = UserNameText.SelectionStart;
            UserNameText.Text = name.ToString();
            UserNameText.SelectionStart = cursorPos;
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            // Сообщить о превышении длины пароля 
            if (PasswordText.Text.Length > 45)
            {
                string message = "Пароль не может превышать 45 знаков!";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordText.Text.Remove(PasswordText.Text.Length - 1);
            }
        }

        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameText.Text))
            {
                string message = "Имя не может быть пустым";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PhoneNumberText.Text.Remove(0,2).Length != 10)
            {
                string message = "Номер телефона должен быть: +7XXXXXXXXXX";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!PasswordText.ReadOnly && PasswordText.Text != PasswordConfirmText.Text)
            {
                string message = "Пароли не совпадают";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(PasswordText.Text))
            {
                string message = "Пароли не может быть пустым";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = UserNameText.Text;
            decimal phone_number = Convert.ToDecimal(PhoneNumberText.Text.Remove(0, 2));
            string password = PasswordText.Text;

            User updatedUser = new User(CurUser.User_code, phone_number, name, password, CurUser.Registration_date);

            try
            {
                IUsersRepository<User> usersRepository = new UsersRepository();

                CurUser = usersRepository.Update(updatedUser);

                string message = "Данные обновлены";
                string caption = "Аккаунт";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                UserNameText.ReadOnly = true;
                PhoneNumberText.ReadOnly = true;
                PasswordText.ReadOnly = true;
                PasswordConfirmLabel.Visible = false;
                PasswordConfirmText.Clear();
                PasswordConfirmText.Visible = false;
                UserName.Text = CurUser.Name;
                Main.setUser(CurUser);
            }
            catch (RepositoryException ex)
            {
                if (ex.ErrorCode == 1062)
                { //Повторение записи
                    string messaage = "Пользователь с указанным номером телефона уже существует";
                    string caption = "Аккаунт";
                    MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                { //Другая ошибка
                    string messaage = "Поизошла ошибка";
                    string caption = "Аккаунт";
                    MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            string message = "Вы действительно хотите удалить аккаунт?";
            string caption = "Аккаунт";
            if(MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    IUsersRepository<User> usersRepository = new UsersRepository();
                    usersRepository.Delete(CurUser);
                    CurUser = null;
                    Main.setUser(CurUser);
                    Close();
                    Main.clearAccountWindow();
                    Main.Show();

                    string mess= "Аккаунт удалён";
                    string capt = "Аккаунт";
                    MessageBox.Show(mess, capt, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (RepositoryException)
                {
                    string mess = "Поизошла ошибка";
                    string capt = "Аккаунт";
                    MessageBox.Show(mess, capt, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
