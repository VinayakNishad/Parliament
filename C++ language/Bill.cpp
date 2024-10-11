#include <iostream>
#include <string>

using namespace std;

// Bill class implementation
class Bill : public Votable {
private:
    string title;
    string status;
    int votes;
    int billId;

public:
    Bill(string title, int billId, string status) : title(title), billId(billId), status(status), votes(0) {}

    string getTitle() {
        return title;
    }

    void setTitle(string title) {
        this->title = title;
    }

    string getStatus() {
        return status;
    }

    void setStatus(string status) {
        this->status = status;
    }

    int getVotes() {
        return votes;
    }

    void setVotes(int votes) {
        this->votes = votes;
    }

    int getBillID() {
        return billId;
    }

    void setBillID(int billId) {
        this->billId = billId;
    }

    // Override vote function
    void vote() override {
        cout << "Voting on bill '" << title << "'" << endl;
        votes++;
    }
};