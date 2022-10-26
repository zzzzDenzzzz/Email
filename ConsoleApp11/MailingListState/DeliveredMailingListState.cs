namespace ConsoleApp11.MailingListState
{
    internal class DeliveredMailingListState : IMailingListState // доставлено
    {
        public void Performed(MailingList mailingList)
        {
        }

        public void Rejected(MailingList mailingList)
        {
        }
    }
}
