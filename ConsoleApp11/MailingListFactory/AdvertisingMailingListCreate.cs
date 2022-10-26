using ConsoleApp11.MailingListState;

namespace ConsoleApp11.MailingListFactory
{
    internal class AdvertisingMailingListCreate : IMailingListCreate
    {
        public IMailingList Create(IMailingListState mailingListState)
        {
            return new Advertising(mailingListState);
        }
    }
}
