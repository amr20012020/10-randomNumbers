#include <iostream>
using namespace std;
int main()
{
    float x;
    cout << "please enter your grade:";
    cin >> x;
    
    if(x >= 90)
    cout << "A" << endl;
    if(x >= 80 && x <=89)
    cout << "B" << endl;
    if(x >=70 && x <=79)
    cout << "C" << endl;
    if(x >= 60 && x <=69)
    cout << "D" << endl;
    if(x >= 50 && x <=59)
    cout << "E" << endl;
    if(x < 50)
    cout << "Fail" << endl; 
    system("pause");
}

