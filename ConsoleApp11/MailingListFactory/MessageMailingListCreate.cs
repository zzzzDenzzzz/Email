using ConsoleApp11.MailingListState;

namespace ConsoleApp11.MailingListFactory
{
    internal class MessageMailingListCreate : IMailingListCreate
    {
        public IMailingList Create(IMailingListState mailingListState)
        {
            return new Message(mailingListState);
        }
    }
}
