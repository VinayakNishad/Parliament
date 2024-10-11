using System;

namespace C__language
{
    public class PresidentOfIndia
    {
        public static void President()
        {
            Console.WriteLine("\"Smt. Droupadi MurmuFor Visit to Rashtrapati Bhavan and Museum:Reception Officer\\r\\n" +
                            "\"\r\n" +
                            "                + //\r\n" +
                            "                \"Phone: 011-23013287 / 23015321 Ext.: 4662, 4751\"");
            while (true)
            {
                Console.WriteLine("President");
                Console.WriteLine("1. vicePresident\n2. primeMinister\n3. councilOfMinisters\n4. governors\n5. ltGovernorsAndAdministrators\n6. chiefMinisters\n7. judgesOfSupremeCourt\n8. chiefsOfArmedForces\n9. membersOfParliament\n10. mlasAndMlcs\n11. Go back to main menu");
                int pchoice = Convert.ToInt32(Console.ReadLine());
                switch (pchoice)
                {
                    case 1:
                        VicePresident();
                        break;
                    case 2:
                        PrimeMinister();
                        break;
                    case 3:
                        CouncilOfMinisters();
                        break;
                    case 4:
                        Governors();
                        break;
                    case 5:
                        LtGovernorsAndAdministrators();
                        break;
                    case 6:
                        ChiefMinisters();
                        break;
                    case 7:
                        JudgesOfSupremeCourt();
                        break;
                    case 8:
                        ChiefsOfArmedForces();
                        break;
                    case 9:
                        MembersOfParliament();
                        break;
                    case 10:
                        MlasAndMlcs();
                        break;
                    case 11:
                        Console.WriteLine("Returning to main menu...");
                        return; // This will exit the while loop and return to main menu
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 11.");
                        break;
                }
            }
        }

        public static void VicePresident()
        {
            Console.WriteLine("Shri Jagdeep DhankharContact Details:Vice-President Enclave, 108, Church Road, New Delhi - 110001\r\n"
                    + //
                    "Phone: 011-23094953, 23094954\r\n"
                    + //
                    "Email: vpindia[at]nic[dot]in");
        }

        public static void PrimeMinister()
        {
            Console.WriteLine("Shri Narendra ModiTo know more about the Prime Minister click hereContact Details:\r\n"
                    + //
                    "Prime Minister's Office\r\n"
                    + //
                    "South Block, Raisina Hill\r\n"
                    + //
                    "New Delhi-110011\r\n"
                    + //
                    "Phone No: +91-11-23012312\r\n"
                    + //
                    "Fax: +91-11-23019545, 23016857\r\n"
                    + //
                    " : https://www.facebook.com/narendramodi\r\n"
                    + //
                    " : https://twitter.com/narendramodi");
        }

        public static void CouncilOfMinisters()
        {
            Console.WriteLine("Prime Minister\r\n"
                    + //
                    "\r\n"
                    + //
                    "Shri Narendra Modi\r\n"
                    + //
                    "Ministry of Personnel, Public Grievances and Pensions\r\n"
                    + //
                    "Department of Atomic Energy\r\n"
                    + //
                    "Department of Space\r\n"
                    + //
                    "All important policy iss");

            Console.WriteLine("Cabinet Ministers");
            string[,] cm = {
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
                "Ministry of Chemicals and Fertilizers"}
        };
            for (int i = 0; i < cm.GetLength(0); i++)
            {
                Console.WriteLine($"{cm[i, 0],-15} {cm[i, 1],-10}");
            }
            Console.WriteLine("Ministers of State (Independent Charge)");
        }

        public static void Governors()
        {
            Console.WriteLine("Governors");

            Console.WriteLine("Indian ParliamentParliament is the supreme legislative body of India. The Indian Parliament comprises of the President and the two Houses - Rajya Sabha (Council of States) and Lok Sabha (House of the People). The President has the power to summon and prorogue either House of Parliament or to dissolve Lok Sabha. The Constitution of India came into force on January 26, 1950. The first general elections under the new Constitution were held during the year 1951-52 and the first elected Parliament came into existence in April, 1952.");
            string[,] data = {
            {"State", "\tGovernor"},
            {"Andhra Pradesh", "\tShri Justice (Retd.) S. Abdul Nazeer"},
            {"Arunachal Pradesh", "\tLt. General Kaiwalya Trivikram Parnaik, PVSM, UYSM, YSM (Retired)"},
            {"Assam", "\tShri Gulab Chand Kataria"}
        };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine($"{data[i, 0],-15} {data[i, 1],-10}");
            }
        }

        public static void LtGovernorsAndAdministrators()
        {
            Console.WriteLine("Lt. Governors & Administrators");
        }

        public static void ChiefMinisters()
        {
            Console.WriteLine("Chief Ministers of States");
        }

        public static void JudgesOfSupremeCourt()
        {
            Console.WriteLine("Judges of Supreme Court of India");
        }

        public static void ChiefsOfArmedForces()
        {
            Console.WriteLine("Chiefs of Armed Forces");
        }

        public static void MembersOfParliament()
        {
            Console.WriteLine("Members of Parliament (MPs)");
        }

        public static void MlasAndMlcs()
        {
            Console.WriteLine("MLAs/MLCs\r\n"
                    + //
                    "Users can click the following links to check official websites of all Legislative Assemblies and Legislative Councils in the country. Each website here also contains a list of Members of Legislative Assembly (MLAs) and Legislative Council (MLCs).");

            string[,] statesData = {
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
            for (int i = 0; i < statesData.GetLength(0); i++)
            {
                Console.WriteLine($"{statesData[i, 0],-20} {statesData[i, 1],-20} {statesData[i, 2],-20}");
            }
        }
    }
}