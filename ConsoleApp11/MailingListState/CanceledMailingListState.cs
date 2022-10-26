namespace ConsoleApp11.MailingListState
{
    internal class CanceledMailingListState : IMailingListState // аннулировано
    {
        public void Performed(MailingList mailingList)
        {
        }

        public void Rejected(MailingList mailingList)
        {
        }
    }
}
