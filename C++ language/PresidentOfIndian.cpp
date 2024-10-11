#include <iostream>
#include <string>
#include <vector>

using namespace std;

class PresidentOfIndia {
public:
    void president() {
        cout << "\"Smt. Droupadi MurmuFor Visit to Rashtrapati Bhavan and Museum:Reception Officer\\r\\n"
             << "\"\\r\\n"
             << "                + //\\r\\n"
             << "                \"Phone: 011-23013287 / 23015321 Ext.: 4662, 4751\"" << endl;

        while (true) {
            cout << "President" << endl;
            cout << "1. vicePresident\n2. primeMinister\n3. councilOfMinisters\n4. governors\n5. ltGovernorsAndAdministrators\n"
                    "6. chiefMinisters\n7. judgesOfSupremeCourt\n8. chiefsOfArmedForces\n9. membersOfParliament\n10. mlasAndMlcs\n11. Go back to main menu"
                 << endl;

            int pchoice;
            cin >> pchoice;

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
                    cout << "Returning to main menu..." << endl;
                    return; // This will exit the while loop and return to main menu
                default:
                    cout << "Invalid choice! Please enter a number between 1 and 11." << endl;
            }
        }
    }

    void vicePresident() {
        cout << "Shri Jagdeep DhankharContact Details:Vice-President Enclave, 108, Church Road, New Delhi - 110001\r\n"
             << "Phone: 011-23094953, 23094954\r\n"
             << "Email: vpindia[at]nic[dot]in" << endl;
    }

    void primeMinister() {
        cout << "Shri Narendra ModiTo know more about the Prime Minister click hereContact Details:\r\n"
             << "Prime Minister's Office\r\n"
             << "South Block, Raisina Hill\r\n"
             << "New Delhi-110011\r\n"
             << "Phone No: +91-11-23012312\r\n"
             << "Fax: +91-11-23019545, 23016857\r\n"
             << " : https://www.facebook.com/narendramodi\r\n"
             << " : https://twitter.com/narendramodi" << endl;
    }

    void councilOfMinisters() {
        cout << "Prime Minister\r\n"
             << "\r\n"
             << "Shri Narendra Modi\r\n"
             << "Ministry of Personnel, Public Grievances and Pensions\r\n"
             << "Department of Atomic Energy\r\n"
             << "Department of Space\r\n"
             << "All important policy iss" << endl;

        cout << "Cabinet Ministers" << endl;
        vector<vector<string>> cm = {
            {"Shri Raj Nath Singh\r\n"
                + //
                "Ministry of Defence", "\tShri Amit Shah\r\n"
                + //
                "Ministry of Home Affairs\r\n"
                + //
                "Ministry of Cooperation"},
            {"Shri Nitin Jairam Gadkari\r\n"
                + //
                "Ministry of Road Transport and Highways", "\tShri Jagat Prakash Nadda\r\n"
                + //
                "Ministry of Health and Family Welfare\r\n"
                + //
                "Ministry of Chemicals and Fertilizers"}};

        for (const auto &ministers : cm) {
            cout << ministers[0] << " " << ministers[1] << endl;
        }

        cout << "Ministers of State (Independent Charge)" << endl;
    }

    void governors() {
        cout << "Governors" << endl;

        vector<vector<string>> data = {
            {"State", "\tGovernor"},
            {"Andhra Pradesh", "\tShri Justice (Retd.) S. Abdul Nazeer"},
            {"Arunachal Pradesh", "\tLt. General Kaiwalya Trivikram Parnaik, PVSM, UYSM, YSM (Retired)"},
            {"Assam", "\tShri Gulab Chand Kataria"}};

        for (const auto &entry : data) {
            cout << entry[0] << " " << entry[1] << endl;
        }
    }

    void ltGovernorsAndAdministrators() {
        cout << "Lt. Governors & Administrators" << endl;
    }

    void chiefMinisters() {
        cout << "Chief Ministers of States" << endl;
    }

    void judgesOfSupremeCourt() {
        cout << "Judges of Supreme Court of India" << endl;
    }

    void chiefsOfArmedForces() {
        cout << "Chiefs of Armed Forces" << endl;
    }

    void membersOfParliament() {
        cout << "Members of Parliament (MPs)" << endl;
    }

    void mlasAndMlcs() {
        cout << "MLAs/MLCs\r\n"
             << "Users can click the following links to check official websites of all Legislative Assemblies and Legislative Councils in the country. Each website here also contains a list of Members of Legislative Assembly (MLAs) and Legislative Council (MLCs)." << endl;

        vector<vector<string>> statesData = {
            {"Andhra Pradesh", "Arunachal Pradesh", "Assam"},
            {"Bihar", "Chhattisgarh", "Delhi"},
            {"Goa", "Gujarat", "Haryana"},
            {"Himachal Pradesh", "Jammu & Kashmir", "Jharkhand"},
            {"Karnataka", "Kerala", "Madhya Pradesh"},
            {"Maharashtra", "Manipur", "Meghalaya"},
            {"Mizoram", "Nagaland", "Odisha"},
            {"Punjab", "Rajasthan", "Sikkim"},
            {"Tamil Nadu", "Telangana", "Tripura"},
            {"Uttarakhand", "Uttar Pradesh", "West Bengal"}};

        // Display the data in 3 columns
        for (const auto &states : statesData) {
            cout << setw(20) << left << states[0] << setw(20) << left << states[1] << setw(20) << left << states[2] << endl;
        }
    }
};
