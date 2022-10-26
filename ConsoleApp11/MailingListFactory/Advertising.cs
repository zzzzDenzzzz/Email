using ConsoleApp11.MailingListState;
using System;

namespace ConsoleApp11.MailingListFactory
{
    // реклама
    internal class Advertising : MailingList, IMailingList
    {
        public Advertising(IMailingListState mailingListState) : base(mailingListState)
        {
        }

        public void Type()
        {
            Console.WriteLine(typeof(Advertising).Name);
        }
    }
}
