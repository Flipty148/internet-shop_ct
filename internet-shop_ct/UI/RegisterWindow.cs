using System.Text;
using System.Text.RegularExpressions;
using internet_shop_ct.RepositoryInterfaces;
using internet_shop_ct.Models;
using internet_shop_ct.Repositories;

namespace internet_shop_ct.UI
{
    public partial class RegisterWindow : Form
    {
        private LoginWindow login;
        public RegisterWindow(LoginWindow window)
        {
            InitializeComponent();
            login = window;
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

        private void PhoneNumberText_Enter(object sender, EventArgs e)
        {
            PhoneNumberText.SelectionStart = 2; //Установить курсор при вводе номера телефона за 7
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

        private void PasswordFirstText_TextChanged(object sender, EventArgs e)
        {
            // Сообщить о превышении длины пароля 
            if (PasswordFirstText.Text.Length > 45)
            {
                string message = "Пароль не может превышать 45 знаков!";
                string caption = "Внимание";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordFirstText.Text.Remove(PasswordFirstText.Text.Length - 1);
            }
                
        }

        private void RegisterButton_MouseClick(object sender, MouseEventArgs e)
        {
            string name = UserNameText.Text; //Считать имя пользователя

            if (string.IsNullOrEmpty(name))
            { //Поле имени пустое
                string messaage = "Имя не может быть пустым!";
                string caption = "Внимание";
                MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PhoneNumberText.Text.Remove(0,2).Length != 10)
            {//Телефон не указан или введён не полностью
                string messaage = "Номер телефона должен быть: +7XXXXXXXXXX";
                string caption = "Внимание";
                MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal phone_number = Convert.ToDecimal(PhoneNumberText.Text.Remove(0,2)); //Номер телефона
            string firstPassword = PasswordFirstText.Text; //Пароль
            string secondPassword = PasswordSecond.Text; //Подтверждение пароля

            if (firstPassword != secondPassword)
            {//Проверка совпадения пароля и его подтверждения
                string messaage = "Пароли должны совпадать";
                string caption = "Внимание";
                MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IUsersRepository<User> usersRepository = new UsersRepository(); //Репозиторий пользователей
            User newUser = new User(phone_number, name, firstPassword); //Новый пользователь 
            try
            {
                newUser = usersRepository.Add(newUser); //Добавления пользователя в БД
            }
            catch (RepositoryException ex)
            {
                if (ex.ErrorCode == 1062)
                { //Повторение записи
                    string messaage = "Пользователь с указанным номером телефона уже существует";
                    string caption = "Внимание";
                    MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                { //Другая ошибка
                    string messaage = "При регистрации произошла ошибка";
                    string caption = "Внимание";
                    MessageBox.Show(messaage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            login.setUser(newUser);
            this.Close();
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
