
namespace C__language
{
    public class MemberOfParliament(string name, string constituency, string party)
    {
        private string name = name;
        private string constituency = constituency;
        private string party = party;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Constituency
        {
            get { return constituency; }
            set { constituency = value; }
        }

        public string Party
        {
            get { return party; }
            set { party = value; }
        }

        internal string GetName()
        {
            throw new NotImplementedException();
        }
    }
}