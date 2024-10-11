// Interface definition (in C++, typically handled via abstract classes with pure virtual functions)
#include <iostream>
#include <string>

using namespace std;
class Votable {
public:
    virtual void vote() = 0; // Pure virtual function
};