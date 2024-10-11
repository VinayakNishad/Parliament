#include <iostream>
#include <string>

using namespace std;

class MemberOfParliament {
private:
    string name;
    string constituency;
    string party;

public:
    MemberOfParliament(string name, string constituency, string party) {
        this->name = name;
        this->constituency = constituency;
        this->party = party;
    }

    string getName() {
        return name;
    }

    void setName(string name) {
        this->name = name;
    }

    string getConstituency() {
        return constituency;
    }

    void setConstituency(string constituency) {
        this->constituency = constituency;
    }

    string getParty() {
        return party;
    }

    void setParty(string party) {
        this->party = party;
    }
};
