#include<iostream>
#include<string>
using namespace std;
struct student
{
     int id;
     char name[20];
     double grades[6];
};
int main()
{
       double sum =0;
       int size;
       cout<<"Enter the number of students";
       cin>> size;
       student *s;
       s=new student[size];
       
       for(int i=0;i<size;i++)
       {
               
       cout<<"Enter id"<<i+1<<":";
       cin>>s[i].id;
       cout<<"Enter name"<<i+1<<":";   
       cin>>s[i].name;
       cout<<"Enter grades of 6 students"<<i+1<<":\n";
       for(int j=0;j<6;j++)
       {
               cin>>s[i].grades[j];
               }
               }
               for(int i=0;i<size;i++)
               {
                       cout<<s[i].name<<" ";
                       cout<<s[i].id<<" ";
                       cout<<"His sum of grades is: ";
                       for(int j=0;j<6;j++)
                       {
                               sum=sum+s[i].grades[j];
                       }
                               cout << sum << endl;
                               sum=0;
                               }
                               
                               delete[] s;
                               system("pause");
                               }
               
       
