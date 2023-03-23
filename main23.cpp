#include<iostream>
#include<string>
using namespace std;
struct student{
       string name;
       double age;
       string add;
       double gpa;
       string phone_num;
       };
       student display(student x)
      {
               cout<<"\n"<<x.name;
               cout<<"\n"<<x.add;
               cout<<"\n"<<x.age;
               cout<<"\n"<<x.phone_num;
               }
               int main()
               {
                   student x;
                   cout<<"Enter The student"<<endl;
                   
                   cout<<"Enter The student name"<<endl;
                   cin>>x.name;
                   cout<<"Enter The student add"<<endl;
                   cin>>x.add;
                   cout<<"Enter The student age"<<endl;
                   cin>>x.age;
                   }
