using ConsoleApp11.MailingListState;
using System;

namespace ConsoleApp11.MailingListFactory
{
    internal class Message : MailingList, IMailingList
    {
        public Message(IMailingListState mailingListState) : base(mailingListState)
        {
        }

        public void Type()
        {
            Console.WriteLine(typeof(Message).Name);
        }
    }
}
