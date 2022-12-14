namespace Lesson_10._4_Kovar_ConterVar
{
    internal class Program
    {
        //Задание 10.4.4
        //Реализуйте данный интерфейс в классе UserService, и продемонстрируйте контравариацию интерфейса в базовом классе Program.
        static void Main(string[] args)
        {
            IUpdater<Account> updater = new UserService();
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}