public class MemberOfParliament {
    private String name;
    private String constituency;
    private String party;

    public MemberOfParliament(String name, String constituency, String party) {
        this.name = name;
        this.constituency = constituency;
        this.party = party;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getConstituency() {
        return constituency;
    }

    public void setConstituency(String constituency) {
        this.constituency = constituency;
    }

    public String getParty() {
        return party;
    }

    public void setParty(String party) {
        this.party = party;
    }

}
