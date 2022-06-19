namespace internet_shop_ct.RepositoryInterfaces
{
    public interface IUsersRepository<T>
    {
        T GetByUserCode(int user_code); //Получить пользователя по его коду

        T GetByLogin(decimal phone_number, string password); //Получить пользователя по его данным (номер телефона и пароль)

        T Add(T newUser); //Добавить пользователя

        T Update(T existingUser); //Обновить данные пользователя

        void Delete(T existingUser); //Удалить пользователя
    }
        
}
