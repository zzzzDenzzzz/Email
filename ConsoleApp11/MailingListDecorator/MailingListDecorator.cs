using ConsoleApp11.MailingListState;

namespace ConsoleApp11.MailingListDecorator
{
    abstract class MailingListDecorator : MailingList
    {
        protected MailingList mailingList;

        public MailingListDecorator(IMailingListState mailingListState, MailingList mailingList) : base(mailingListState)
        {
            this.mailingList = mailingList;
        }
    }
}
