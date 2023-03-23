#include<iostream>
#include<cmath>
using namespace std;

int main() {
	cout << "Hello, Welcome to my App" << endl;
	cout << "Please Create new account" << endl;
	cout << "Choose a username:" << endl;
	string user;
	cin >> user;
	cout << "Choose a password:" << endl;
	string pass;
	cin >> pass;


	cout << "Please Enter Your Information" << endl;
	cout << "Username: " << endl;
	string username;
	cin >> username;

	cout << "password:" << endl;
	string password;
	cin >> password;

	while (username != user && password != pass) {
		cout << "Wrong Username Or Password Please Try Again!"<<endl;
		cout << "Username: " << endl;
		cin >> username;
		cout << "Password: " << endl;
		cin >> password;
	}

	cout << "Welcome to the bagel app" << endl;
	double balance = 5.00;
	cout << "Would you like to add money to your balanece?" << endl;
	string ql;
	cin >> ql;
	if (ql == "yes") {
		cout << "enter how much money to you want to add: " << endl;
		double add;
		cin >> add;
		cout << "your new balance is" << balance + add << " dollers" << endl;

	}
	else {
		cout << "alright"<<endl;
	}
	cout << "Would you like a bagel today?" << endl;
	return 0;
}