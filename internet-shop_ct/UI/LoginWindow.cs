using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;
using System.Text.RegularExpressions;
using internet_shop_ct.internet_shop_ct.UI;
using internet_shop_ct.UI;

namespace internet_shop_ct.UI
{
    public partial class LoginWindow : Form
    {
        private MainWindow main;
        public LoginWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            PhoneNumberText.SelectionStart += 2;
            main = mainWindow;
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
                if(e.KeyChar == '\b')
                {
                    if (PhoneNumberText.SelectionStart - 1 >=0 && !regex.IsMatch(this.PhoneNumberText.Text.Remove(PhoneNumberText.SelectionStart-1, 1)))
                        e.Handled = true;
                    return;
                }

                e.Handled = false;
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

        private void LoginButton_MouseClick(object sender, MouseEventArgs e)
        {
            IUsersRepository<User> usersRepository = new UsersRepository(); //Репозиторий пользователей

            if (this.PhoneNumberText.Text.Remove(0,2).Length != 10)
            { //Проверить наличие номера телефона
                this.ErrorLabel.Text = "Номер телефона должен быть: +7XXXXXXXXXX";
                this.ErrorLabel.Visible = true; //Вывести сообщение об ошибке
                return;
            }

            if (string.IsNullOrEmpty(this.PasswordText.Text))
            { //Проверить наличие пароля
                this.ErrorLabel.Text = "Введите пароль";
                this.ErrorLabel.Visible = true; //Вывести сообщение об ошибке
                return;
            }
            decimal phone_number = Convert.ToDecimal(this.PhoneNumberText.Text.Remove(0, 2)); //Получение номера телефона
            string password = this.PasswordText.Text; //Получение пароля
            User user = usersRepository.GetByLogin(phone_number, password); //Получение пользователя при входе

            if (user == null)
            { //Пользователь не найден
                this.ErrorLabel.Text = "Неверный номер телефона или пароль";
                this.ErrorLabel.Visible = true; //Вывести сообщение об ошибке
                return;
            }

            main.setUser(user);
            this.Close();
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }
    }
}
