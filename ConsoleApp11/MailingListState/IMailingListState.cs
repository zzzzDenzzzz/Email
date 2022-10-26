namespace ConsoleApp11.MailingListState
{
    internal interface IMailingListState
    {
        void Performed(MailingList mailingList); // выполнено
        void Rejected(MailingList mailingList); // отклонено
    }
}
