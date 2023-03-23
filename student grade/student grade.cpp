#include<iostream>
using namespace std;
int main() {
	struct student {
		int id;
		string name;
		int grades[6];
	};
	student s[3];
	for (int i = 0; i < 3; i++) {
		cout << "Enetr the id of student" << i + 1 << ":";
		cin >> s[i].id;
		cout << "Enetr the name of student" << i + 1 << ":";
		cin >> s[i].name;
		cout << "Enter the 6 grades of student" << i + 1 << ":";
		for (int J = 0; J < 6; J++)
			cin >> s[i].grades[J];
	}
	int sum;
	for (int i = 0; i < 3; i++)
		sum = 0;
	cout << "Sum of grades of student" << "\t";
	for (int J = 0; J < 6; J++) {
		sum += s[].grades[J];
	}
	cout << sum << endl;
}