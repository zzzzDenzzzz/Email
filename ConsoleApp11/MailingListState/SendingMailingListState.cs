namespace ConsoleApp11.MailingListState
{
    internal class SendingMailingListState : IMailingListState // отправка
    {
        public void Performed(MailingList mailingList)
        {
            mailingList.State = new DeliveredMailingListState();
        }

        public void Rejected(MailingList mailingList)
        {
            mailingList.State = new CanceledMailingListState();
        }
    }
}
