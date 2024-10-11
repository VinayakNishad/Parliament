# Correct import statements assuming these classes are in separate modules
from PresidentOfIndia import PresidentOfIndia
from Bill import Bill
from MemberOfPerliament import MemberOfParliament

class IndianParliamentMenu:
    def __init__(self):
        self.members = []
        self.bills = []
        self.votedBills = []

    def main(self):
        print("\nWelcome to the Indian Parliament")
        self.homeInfo()
        while True:
            print("\n1. President of India")
            print("2. Rajya Sabha of India")
            print("3. Lok Sabha of India")
            print("4. View Members of Parliament")
            print("5. Introduce a New Bill")
            print("6. View All Bills")
            print("7. Add Member")
            print("8. Vote on a Bill")
            print("9. View Voted Bills")
            print("0. Exit")

            choice = int(input("Please enter your choice: "))

            if choice == 1:
                p=PresidentOfIndia()
                p.president()
            elif choice == 2:
                self.rajyaSabha()
            elif choice == 3:
                self.lokSabha()
            elif choice == 4:
                self.viewMembers()
            elif choice == 5:
                self.introduceBill()
            elif choice == 6:
                self.viewAllBills()
            elif choice == 7:
                self.addMember()
            elif choice == 8:
                self.voteOnBill()
            elif choice == 9:
                self.viewVotedBills()
            elif choice == 0:
                print("Exiting...")
                break
            else:
                print("Invalid choice! Please enter a number between 0 and 9.")

    def rajyaSabha(self):
        # Implement functionality for Rajya Sabha
        pass

    def lokSabha(self):
        # Implement functionality for Lok Sabha
        pass

    def introduceBill(self):
        title = input("Enter the title of the new bill:")
        billID = int(input("Enter the ID of the new bill:"))
        status = input("Enter the status of the new bill:")
        newBill = Bill(title, billID, status)
        self.bills.append(newBill)
        print(f"New bill '{title}' has been introduced.")

    def viewAllBills(self):
        print("Here are all the bills that have been introduced:")
        for i, bill in enumerate(self.bills, start=1):
            print(f"{i}. {bill.getTitle()} - Status: {bill.getStatus()} - Votes: {bill.getVotes()} - Bill ID: {bill.getBillID()}")

    def voteOnBill(self):
        billId = int(input("Enter the ID of the bill you want to vote on:"))
        billToVote = self.findBillById(billId)
        if billToVote:
            billToVote.vote()
            self.votedBills.append(billToVote)
            print(f"You have voted on bill '{billToVote.getTitle()}'.")
        else:
            print("Invalid bill ID. Please enter a valid bill ID.")

    def findBillById(self, billId):
        for bill in self.bills:
            if bill.getBillID() == billId:
                return bill
        return None

    def viewVotedBills(self):
        print("Here are the bills that have been voted on:")
        for i, bill in enumerate(self.votedBills, start=1):
            print(f"{i}. {bill.getTitle()} - Votes: {bill.getVotes()}")

    def addMember(self):
        name = input("Enter the name of the new member:")
        constituency = input("Enter the constituency:")
        party = input("Enter the party:")
        newMember = MemberOfParliament(name, constituency, party)
        self.members.append(newMember)
        print(f"Member '{name}' has been added.")

    def viewMembers(self):
        print("Here are the current members of the Indian Parliament:")
        for i, member in enumerate(self.members, start=1):
            print(f"{i}. {member.getName()} ({member.getConstituency()}, {member.getParty()})")

    @staticmethod
    def homeInfo():
        print("Indian Parliament is the supreme legislative body of India. The Indian Parliament comprises of the President and the two Houses - Rajya Sabha (Council of States) and Lok Sabha (House of the People). The President has the power to summon and prorogue either House of Parliament or to dissolve Lok Sabha. The Constitution of India came into force on January 26, 1950. The first general elections under the new Constitution were held during the year 1951-52 and the first elected Parliament came into existence in April, 1952.")

if __name__ == "__main__":
    menu = IndianParliamentMenu()
    menu.main()
