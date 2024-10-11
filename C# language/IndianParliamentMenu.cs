using System;
using System.Collections.Generic;

namespace C_language // Adjusted the namespace name to follow C# conventions
{
    public class IndianParliamentMenu
    {
        private static List<MemberOfParliament> members = new List<MemberOfParliament>();
        private static List<Bill> bills = new List<Bill>();
        private static List<Bill> votedBills = new List<Bill>();

        public static void Main(string[] args)
        {
            PresidentOfIndia poi = new PresidentOfIndia();
            Console.WriteLine("\nWelcome to the Indian Parliament");
            HomeInfo();

            while (true)
            {
                Console.WriteLine("1. President of India");
                Console.WriteLine("2. Rajya Sabha of India");
                Console.WriteLine("3. Lok Sabha of India");
                Console.WriteLine("4. View Members of Parliament");
                Console.WriteLine("5. Introduce a New Bill");
                Console.WriteLine("6. View All Bills");
                Console.WriteLine("7. Add Member");
                Console.WriteLine("8. Vote on a Bill");
                Console.WriteLine("9. View Voted Bills");
                Console.WriteLine("0. Exit");
                Console.Write("Please enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            poi.President();
                            break;
                        case 2:
                            RajyaSabha();
                            break;
                        case 3:
                            LokSabha();
                            break;
                        case 4:
                            ViewMembers();
                            break;
                        case 5:
                            IntroduceBill();
                            break;
                        case 6:
                            ViewAllBills();
                            break;
                        case 7:
                            AddMember();
                            break;
                        case 8:
                            VoteOnBill();
                            break;
                        case 9:
                            ViewVotedBills();
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            return; // Exit the loop
                        default:
                            Console.WriteLine("Invalid choice! Please enter a number between 0 and 9.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
        }

        private static void RajyaSabha()
        {
            Console.WriteLine("The Rajya Sabha should consist of not more than 250 members...");
        }

        private static void LokSabha()
        {
            Console.WriteLine("The Lok Sabha is composed of representatives of people...");
        }

        private static void IntroduceBill()
        {
            Console.Write("Enter the title of the new bill: ");
            string title = Console.ReadLine();
            Console.Write("Enter the ID of the new bill: ");
            int billID = int.Parse(Console.ReadLine()); // Add error handling as needed
            Console.Write("Enter the status of the new bill: ");
            string status = Console.ReadLine();

            Bill newBill = new Bill(title, billID, status);
            bills.Add(newBill);
            Console.WriteLine("New bill '" + title + "' has been introduced.");
        }

        private static void ViewAllBills()
        {
            Console.WriteLine("Here are all the bills that have been introduced:");
            for (int i = 0; i < bills.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + bills[i].Title +
                                  " - Status: " + bills[i].Status +
                                  " - Votes: " + bills[i].Votes +
                                  " - Bill ID: " + bills[i].BillId);
            }
        }

        private static void VoteOnBill()
        {
            Console.WriteLine("Enter the ID of the bill you want to vote on:");
            int billId = int.Parse(Console.ReadLine()); // Add error handling as needed
            Bill billToVote = FindBillById(billId);

            if (billToVote != null)
            {
                billToVote.Vote();
                votedBills.Add(billToVote);
                Console.WriteLine("You have voted on bill '" + billToVote.Title + "'.");
            }
            else
            {
                Console.WriteLine("Invalid bill ID. Please enter a valid bill ID.");
            }
        }

        private static Bill FindBillById(int billId)
        {
            return bills.Find(bill => bill.BillId == billId);
        }

        private static void ViewVotedBills()
        {
            Console.WriteLine("Here are the bills that have been voted on:");
            for (int i = 0; i < votedBills.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + votedBills[i].Title +
                                  " - Votes: " + votedBills[i].Votes);
            }
        }

        private static void AddMember()
        {
            Console.WriteLine("Enter the name of the new member:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the constituency:");
            string constituency = Console.ReadLine();
            Console.WriteLine("Enter the party:");
            string party = Console.ReadLine();

            MemberOfParliament newMember = new MemberOfParliament(name, constituency, party);
            members.Add(newMember);
            Console.WriteLine("Member '" + name + "' has been added.");
        }

        private static void ViewMembers()
        {
            Console.WriteLine("Here are the current members of the Indian Parliament:");
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + members[i].GetName() +
                                  " (" + members[i].GetConstituency() +
                                  ", " + members[i].GetParty() + ")");
            }
        }

        public static void HomeInfo()
        {
            Console.WriteLine("Indian Parliament is the supreme legislative body of India...");
            // Display additional information or formatting as needed
        }
    }

    public class Bill : IVotable
    {
        private string title;
        private string status;
        private int votes;
        private int billId;

        public Bill(string title, int billId, string status)
        {
            this.title = title;
            this.status = status;
            this.billId = billId;
            votes = 0;
        }

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

    // Assuming a placeholder for MemberOfParliament class
    public class MemberOfParliament
    {
        private string name;
        private string constituency;
        private string party;

        public MemberOfParliament(string name, string constituency, string party)
        {
            this.name = name;
            this.constituency = constituency;
            this.party = party;
        }

        public string GetName() => name;
        public string GetConstituency() => constituency;
        public string GetParty() => party;
    }

    // Assuming a placeholder for IVotable interface
    public interface IVotable
    {
        void Vote();
    }

    // Assuming a placeholder for PresidentOfIndia class
    public class PresidentOfIndia
    {
        public void President()
        {
            Console.WriteLine("Information about the President of India...");
        }
    }
}
