using ConsoleApp11.MailingListState;

namespace ConsoleApp11
{
    abstract class MailingList
    {
        public IMailingListState State { get; set; }

        public MailingList(IMailingListState mailingListState)
        {
            State = mailingListState;
        }

        public void Performed() // выполнено
        {
            State.Performed(this);
        }

        public void Rejected() // отклонено
        {
            State.Rejected(this);
        }
    }
}
