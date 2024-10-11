import java.util.Scanner;

public class PresidentOfIndia {

     public void president() {
        System.out.println("Smt. Droupadi MurmuFor Visit to Rashtrapati Bhavan and Museum:Reception Officer\n" +
                        "Phone: 011-23013287");
        while (true) {
            System.out.println("President");
            System.out.println("1. vicePresident\n2. primeMinister\n3. councilOfMinisters\n4. governors\n5. ltGovernorsAndAdministrators\n6. chiefMinisters\n7. judgesOfSupremeCourt\n8. chiefsOfArmedForces\n9. membersOfParliament\n10. mlasAndMlcs\n11. Go back to main menu");
            Scanner sc = new Scanner(System.in);
            int pchoice = sc.nextInt();
            switch (pchoice) {
                case 1:
                    vicePresident();
                    break;
                case 2:
                    primeMinister();
                    break;
                case 3:
                    councilOfMinisters();
                    break;
                case 4:
                    governors();
                    break;
                case 5:
                    ltGovernorsAndAdministrators();
                    break;
                case 6:
                    chiefMinisters();
                    break;
                case 7:
                    judgesOfSupremeCourt();
                    break;
                case 8:
                    chiefsOfArmedForces();
                    break;
                case 9:
                    membersOfParliament();
                    break;
                case 10:
                    mlasAndMlcs();
                    break;
                case 11:
                    System.out.println("Returning to main menu...");
                    return; // This will exit the while loop and return to main menu
                default:
                    System.out.println("Invalid choice! Please enter a number between 1 and 11.");
            }
        }
    }
    


    public void vicePresident() {
        System.out.println("Shri Jagdeep DhankharContact Details:Vice-President Enclave, 108, Church Road, New Delhi - 110001\n"
                + 
                "Phone: 011-23094953, 23094954\n"
                + 
                "Email: vpindia.nic.in");
    }

    public void primeMinister() {
        System.out.println("Shri Narendra ModiTo know more about the Prime Minister click hereContact Details:\n"
                + 
                "Prime Minister's Office\n"
                + 
                "South Block, Raisina Hill\n"
                + 
                "New Delhi-110011\n"
                + 
                "Phone No: +91-11-23012312\n"
                + 
                "Fax: +91-11-23019545, 23016857\n"
                +
                " : https://www.facebook.com/narendramodi\n"
                + 
                " : https://twitter.com/narendramodi");
    }

    public void councilOfMinisters() {
        System.out.println("Prime Minister\n"
                + 
                "\n"
                + 
                "Shri Narendra Modi\n"
                + 
                "Ministry of Personnel, Public Grievances and Pensions\n"
                + 
                "Department of Atomic Energy\n"
                + 
                "Department of Space\n"
                + 
                "All important policy iss");

        System.out.println("Cabinet Ministers");
        String[][] cm = {
            {"Shri Raj Nath Singh\n"
                + 
                "Ministry of Defence", "\tShri Amit Shah\n"
                + 
                "Ministry of Home Affairs\n"
                + 
                "Ministry of Cooperation"},
            {"Shri Nitin Jairam Gadkari\n"
                + 
                "Ministry of Road Transport and Highways", "\tShri Jagat Prakash Nadda\n"
                + 
                "Ministry of Health and Family Welfare\n"
                + 
                "Ministry of Chemicals and Fertilizers"},};
        for (int i = 0; i < cm.length; i++) {
            System.out.printf("%-15s %-10s\n", cm[i][0], cm[i][1]);
        }
        System.out.println("Ministers of State (Independent Charge)");

    }

    public void governors() {
        System.out.println("Governors");

        System.out.println("Indian ParliamentParliament is the supreme legislative body of India. The Indian Parliament comprises of the President and the two Houses - Rajya Sabha (Council of States) and Lok Sabha (House of the People). The President has the power to summon and prorogue either House of Parliament or to dissolve Lok Sabha. The Constitution of India came into force on January 26, 1950. The first general elections under the new Constitution were held during the year 1951-52 and the first elected Parliament came into existence in April, 1952.");
        String[][] data = {
            {"State", "\tGovernor"},
            {"Andhra Pradesh", "\tShri Justice (Retd.) S. Abdul Nazeer"},
            {"Arunachal Pradesh", "\tLt. General Kaiwalya Trivikram Parnaik, PVSM, UYSM, YSM (Retired)"},
            {"Assam", "\tShri Gulab Chand Kataria"}
        };
        System.out.printf("%-15s %-10s\n", data[0][0], data[0][1]);
        for (int i = 1; i < data.length; i++) {
            System.out.printf("%-15s %-10s\n", data[i][0], data[i][1]);
        }

    }

    public void ltGovernorsAndAdministrators() {
        System.out.println("Lt. Governors & Administrators");
    }

    public void chiefMinisters() {
        System.out.println("Chief Ministers of States");
    }

    public void judgesOfSupremeCourt() {
        System.out.println("Judges of Supreme Court of India");
    }

    public void chiefsOfArmedForces() {
        System.out.println("Chiefs of Armed Forces");
    }

    public void membersOfParliament() {
        System.out.println("Members of Parliament (MPs)");
    }

    public void mlasAndMlcs() {
        System.out.println("MLAs/MLCs\n"
                + //
                "Users can click the following links to check official websites of all Legislative Assemblies and Legislative Councils in the country. Each website here also contains a list of Members of Legislative Assembly (MLAs) and Legislative Council (MLCs).");

        String[][] statesData = {
            {"Andhra Pradesh", "Arunachal Pradesh", "Assam"},
            {"Bihar", "Chhattisgarh", "Delhi"},
            {"Goa", "Gujarat", "Haryana"},
            {"Himachal Pradesh", "Jammu & Kashmir", "Jharkhand"},
            {"Karnataka", "Kerala", "Madhya Pradesh"},
            {"Maharashtra", "Manipur", "Meghalaya"},
            {"Mizoram", "Nagaland", "Odisha"},
            {"Punjab", "Rajasthan", "Sikkim"},
            {"Tamil Nadu", "Telangana", "Tripura"},
            {"Uttarakhand", "Uttar Pradesh", "West Bengal"}
        };

        // Display the data in 3 columns
        for (int i = 0; i < statesData.length; i++) {
            System.out.printf("%-20s %-20s %-20s\n", statesData[i][0], statesData[i][1], statesData[i][2]);
        }
    }

}