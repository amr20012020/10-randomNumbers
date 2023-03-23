#include<iostream>
using namespace std;
int top = -1;
const int Size = 5;
int stack_arr[Size];
bool isFull()
{
	if (top == Size - 1)
		return true;
	else
		return false;
}
void push(int pushed_item)
{
	if (isFull())
		cout << "stack overFlow\n";
	else
	{
		top++;
		stack_arr[top] = pushed_item;
	}
	bool isEmpty()
	{
		if (top == -1)
			return true;
		else
			return False;
	}
	int pop()
	{
		if (isEmpty())
			cout << "stack overflow\n";
		else
		{
			int item = stack_arr[top];
			top--;
			return item;
		}
	}
	return -1;
}