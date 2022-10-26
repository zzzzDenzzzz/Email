namespace ConsoleApp11.MailingListState
{
    internal class DevelopmentMailingListState : IMailingListState // разработка
    {
        public void Performed(MailingList mailingList)
        {
            mailingList.State = new ExaminationMailingListState();
        }

        public void Rejected(MailingList mailingList)
        {
            mailingList.State = new CanceledMailingListState();
        }
    }
}
