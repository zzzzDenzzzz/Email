using ConsoleApp11.MailingListState;

namespace ConsoleApp11.MailingListFactory
{
    internal interface IMailingListCreate
    {
        IMailingList Create(IMailingListState mailingListState);
    }
}
