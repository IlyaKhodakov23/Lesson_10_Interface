namespace Lesson_10_2_Interface
{
    internal class Program
    {
        //Задание 10.2.2
        //Используя теоретический материал из данного юнита, постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:
        static void Main(string[] args)
        {
            Message message = new Message();
            ((IWriter)message).Write();

            IWriter writer = new FileManager();
            IReader reader = new FileManager();
            IMailer mailer = new FileManager();
            FileManager fileManager = new FileManager();
            //((IWriter)fileManager).Write(); //Вариант вызова метода интерфейса
            writer.Write();
            reader.Read();
            mailer.SendEmail();
            
        }
    }

    public interface IWriter
    {
        void Write();
    }

    class Message : IWriter
    {
        void IWriter.Write()
        {
            
        }
    }

    //Задание 10.3.1
    //Создайте класс FileManager и выполните в нём множественную реализацию интерфейсов, указанных в примере выше.
    //public interface IWriter
    //{
    //    void Write();
    //}

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    class FileManager : IWriter, IReader, IMailer
    {
        void IReader.Read()
        {
            throw new NotImplementedException();
        }

        void IMailer.SendEmail()
        {
            throw new NotImplementedException();
        }

        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
}