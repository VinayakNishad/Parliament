using System;
using C__language;

namespace CSharpLanguage
{
    public class Bill(string title, int billId, string status) : IVotable
    {
        private string title = title;
        private string status = status;
        private int votes = 0;
        private int billId = billId;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Votes
        {
            get { return votes; }
            set { votes = value; }
        }

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }

        public void Vote()
        {
            Console.WriteLine("Voting on bill '" + title + "'");
            votes++;
        }
    }
}
