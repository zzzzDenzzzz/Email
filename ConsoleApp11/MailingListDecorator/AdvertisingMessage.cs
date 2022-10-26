using ConsoleApp11.MailingListFactory;
using ConsoleApp11.MailingListState;
using System;

namespace ConsoleApp11.MailingListDecorator
{
    internal class AdvertisingMessage : MailingListDecorator, IMailingList
    {
        public AdvertisingMessage(IMailingListState mailingListState, MailingList mailingList) : base(mailingListState, mailingList)
        {
        }

        public void Type()
        {
            Console.WriteLine(typeof(AdvertisingMessage).Name + " " + mailingList.GetType());
        }
    }
}
