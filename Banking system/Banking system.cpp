#include<iostream>
using namespace std;
int cost = 0;
bool result = false;
struct customer
{
	string name;
	int telepone;
	string addres;
	int national_iD;

} customer[1000];
void add_new()
{
	char other;
	for (cost; cost < 1000; )
	{
		result = true;
		cout << "enter name:";
		cin >> customer[cost].name;
		cout << "enter phone:";
		cin >> customer[cost].telepone;
		cout << "enter addres:";
		cin >> customer[cost].addres;
		cout << "enter national id:";
		cin >> customer[cost].national_iD;
		cout << "____________________\n";
		cout << "to add customer other press y for no press n:";
		cin >> other;
		if (other == 'y')
		{
			cost++;
			cout << "____________________\n";
		}
		else
		{
			cost++;
			cout << "____________________\n";
			break;

		}

	}


}
void display()
{
	if (result == true)
	{
		for (int i = 0; i < cost; i++)
		{
			cout << "the name:" << customer[i].name << endl;
			cout << "the phone:" << customer[i].telepone << endl;
			cout << "the addres:" << customer[i].addres << endl;
			cout << "the national id:" << customer[i].national_iD << endl;
			cout << "____________________\n";
		}
	}
	else
	{
		cout << "no acount\n";
		cout << "_____________________\n";
	}
}
int main()
{
	int press = 0;
	cout << "press 1 to add customer\n";
	cout << "press 2 to View customer data\n";
	cout << "press 3 to exit programming\n";
	do
	{
		cout << "press any key:";
		cin >> press;
		switch (press)
		{
		case (1):
			add_new();
			break;
		case (2):
			display();
			break;
		}
	} while (press != 3);
	return 0;
}