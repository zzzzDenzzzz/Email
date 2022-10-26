using ConsoleApp11.MailingListDecorator;
using ConsoleApp11.MailingListFactory;
using ConsoleApp11.MailingListState;
using System;

namespace ConsoleApp11
{
    internal class Program
    {
        public static void PrintLine() => Console.WriteLine(new string('-', 35));

        static void Main(string[] args)
        {
            var message = new Message(new DevelopmentMailingListState());
            message.Type();
            Console.WriteLine(message.State);
            message.Performed();
            Console.WriteLine(message.State);
            message.Performed();
            Console.WriteLine(message.State);
            message.Performed();
            Console.WriteLine(message.State);

            PrintLine();

            var advertising = new Advertising(new DevelopmentMailingListState());
            advertising.Type();
            Console.WriteLine(advertising.State);
            advertising.Performed();
            Console.WriteLine(advertising.State);
            advertising.Performed();
            Console.WriteLine(advertising.State);
            advertising.Performed();
            Console.WriteLine(advertising.State);

            PrintLine();

            var advertisignMessage = new AdvertisingMessage(new DevelopmentMailingListState(), message);
            advertisignMessage.Type();
            Console.WriteLine(advertisignMessage.State);
            advertisignMessage.Performed();
            Console.WriteLine(advertisignMessage.State);
            advertisignMessage.Performed();
            Console.WriteLine(advertisignMessage.State);
            advertisignMessage.Performed();
            Console.WriteLine(advertisignMessage.State);

            PrintLine();

            DataBase dataBase = new DataBase();
            dataBase.AddMail("@mailku.ku");
            dataBase.Sending(dataBase.GetMail(0), message, advertising, advertisignMessage);
            string[] mails = { "1", "2", "3", "4", "5", "6", };
            dataBase.AllSending(mails, message, advertising, advertisignMessage);

            PrintLine();
        }
    }
}
