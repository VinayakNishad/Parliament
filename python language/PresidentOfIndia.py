class PresidentOfIndia:
    
    def president(self):
        print("\nSmt. Droupadi MurmuFor Visit to Rashtrapati Bhavan and Museum:Reception Officer\n"
              + "\n"
              + "Phone: 011-23013287 \t 23015321 Ext.: 4662, 4751\n")
        
        while True:
            print("1. vicePresident\n2. primeMinister\n3. councilOfMinisters\n4. governors\n5. ltGovernorsAndAdministrators\n6. chiefMinisters\n7. judgesOfSupremeCourt\n8. chiefsOfArmedForces\n9. membersOfParliament\n10. mlasAndMlcs\n11. Go back to main menu")
            pchoice = int(input("Enter your choice :"))
            if pchoice == 1:
                self.vicePresident()
            elif pchoice == 2:
                self.primeMinister()
            elif pchoice == 3:
                self.councilOfMinisters()
            elif pchoice == 4:
                self.governors()
            elif pchoice == 5:
                self.ltGovernorsAndAdministrators()
            elif pchoice == 6:
                self.chiefMinisters()
            elif pchoice == 7:
                self.judgesOfSupremeCourt()
            elif pchoice == 8:
                self.chiefsOfArmedForces()
            elif pchoice == 9:
                self.membersOfParliament()
            elif pchoice == 10:
                self.mlasAndMlcs()
            elif pchoice == 11:
                print("Returning to main menu...")
                return
            else:
                print("Invalid choice! Please enter a number between 1 and 11.")
    
    def vicePresident(self):
        print("Shri Jagdeep DhankharContact Details:Vice-President Enclave, 108, Church Road, New Delhi - 110001\n"
              + "Phone: 011-23094953, 23094954\n"
              + "Email: vpindia@gmail.com")
    
    def primeMinister(self):
        print("Shri Narendra ModiTo know more about the Prime Minister click hereContact Details:\n"
              + "Prime Minister's Office\n"
              + "South Block, Raisina Hill\n"
              + "New Delhi-110011\n"
              + "Phone No: +91-11-23012312\n"
              + "Fax: +91-11-23019545, 23016857\n"
              + " : https://www.facebook.com/narendramodi\n"
              + " : https://twitter.com/narendramodi")
    
    def councilOfMinisters(self):
        print("Prime Minister\n"
              + "\n"
              + "Shri Narendra Modi\n"
              + "Ministry of Personnel, Public Grievances and Pensions\n"
              + "Department of Atomic Energy\n"
              + "Department of Space\n"
              + "All important policy iss")
        
        print("Cabinet Ministers")
        cm = [
            ["Shri Raj Nath Singh\n"
             + "Ministry of Defence", "\tShri Amit Shah\n"
             + "Ministry of Home Affairs\n"
             + "Ministry of Cooperation"],
            ["Shri Nitin Jairam Gadkari\n"
             + "Ministry of Road Transport and Highways", "\tShri Jagat Prakash Nadda\n"
             + "Ministry of Health and Family Welfare\n"
             + "Ministry of Chemicals and Fertilizers"]
        ]
        
        for item in cm:
            print("{:<15} {:<10}".format(item[0], item[1]))
        
        print("Ministers of State (Independent Charge)")

    def governors(self):
        print("Governors")
        
        data = [
            ["State", "\tGovernor"],
            ["Andhra Pradesh", "\tShri Justice (Retd.) S. Abdul Nazeer"],
            ["Arunachal Pradesh", "\tLt. General Kaiwalya Trivikram Parnaik, PVSM, UYSM, YSM (Retired)"],
            ["Assam", "\tShri Gulab Chand Kataria"]
        ]
        
        for item in data:
            print("{:<15} {:<10}".format(item[0], item[1]))

    def ltGovernorsAndAdministrators(self):
        print("Lt. Governors & Administrators")

    def chiefMinisters(self):
        print("Chief Ministers of States")

    def judgesOfSupremeCourt(self):
        print("Judges of Supreme Court of India")

    def chiefsOfArmedForces(self):
        print("Chiefs of Armed Forces")

    def membersOfParliament(self):
        print("Members of Parliament (MPs)")

    def mlasAndMlcs(self):
        print("MLAs/MLCs\n"
              + "Users can click the following links to check official websites of all Legislative Assemblies and Legislative Councils in the country. Each website here also contains a list of Members of Legislative Assembly (MLAs) and Legislative Council (MLCs).")
        
        statesData = [
            ["Andhra Pradesh", "Arunachal Pradesh", "Assam"],
            ["Bihar", "Chhattisgarh", "Delhi"],
            ["Goa", "Gujarat", "Haryana"],
            ["Himachal Pradesh", "Jammu & Kashmir", "Jharkhand"],
            ["Karnataka", "Kerala", "Madhya Pradesh"],
            ["Maharashtra", "Manipur", "Meghalaya"],
            ["Mizoram", "Nagaland", "Odisha"],
            ["Punjab", "Rajasthan", "Sikkim"],
            ["Tamil Nadu", "Telangana", "Tripura"],
            ["Uttarakhand", "Uttar Pradesh", "West Bengal"]
        ]
        
        for row in statesData:
            print("{:<20} {:<20} {:<20}".format(row[0], row[1], row[2]))

