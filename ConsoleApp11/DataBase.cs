using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    internal class DataBase
    {
        List<string> email;

        public DataBase()
        {
            email = new List<string>();
        }

        public void AddMail(params string[] mail)
        {
            foreach (string mailItem in mail)
            {
                email.Add(mailItem);
            }
        }

        public string GetMail(int index)
        {
            return email[index];
        }

        public void Sending(string mail, params MailingList[] mailingList)
        {
            Console.WriteLine($"{mail} sending:");
            foreach (MailingList mailing in mailingList)
            {
                Console.WriteLine($"{mailing}");
            }
        }

        public void AllSending(string[] mail, params MailingList[] mailingList)
        {
            foreach(var i in mail)
            {
                Sending(i, mailingList);
            }
        }
    }
}
