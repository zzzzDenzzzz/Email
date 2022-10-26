namespace ConsoleApp11.MailingListState
{
    internal class ExaminationMailingListState : IMailingListState // проверка
    {
        public void Performed(MailingList mailingList)
        {
            mailingList.State = new SendingMailingListState();
        }

        public void Rejected(MailingList mailingList)
        {
            mailingList.State = new CanceledMailingListState();
        }
    }
}
