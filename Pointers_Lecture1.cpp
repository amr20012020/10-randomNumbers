 #include <iostream>
 #include <iomanip>
 
using namespace std;

int cubeByValue( int ); // prototype
void cubeByReference( int * ); // prototype
//*********************************************************************************************
int doubleByValue( long double);
void doubleByReference(  long double * );
//*********************************************************************************************
void selectionSort( int [], const int, bool (*)( int, int ));
void swap( int * const, int * const );
bool ascending( int, int ); // implements ascending order
bool descending( int, int ); // implements descending order
//*********************************************************************************************

int main()
{
	

//  /*
	int a=3;
	int *aPtr=&a;
	cout <<"&a " <<&a<<endl;
	*aPtr=10;
	
	int *b, *c, *d;
	b=&a;
	c=&a;
	d=&a;
	cout<< setw(6)<<"*b=" << setw(6)<< *b << setw(6)<<"  *c=" <<setw(6)<<*c<< setw(6)<<"  *d=" <<setw(6)<<*d<<endl;
	cout<< setw(6)<<"b=" << setw(6)<< b << setw(6)<< "  c=" <<setw(6)<< c<< setw(6)<<"  d=" <<setw(6)<<d<<endl;
	cout<< setw(6)<<"&b=" << setw(6)<<&b << setw(6)<<"  &c=" <<setw(6)<<&c<<setw(6)<< "  &d=" <<setw(6)<<&d<<endl;
	
	int *nullptr=NULL;
	int *bPtr=0;
	cout<<"The value of nullptr is "<<nullptr<<endl;
	cout<<"The address of the nullptr is "<<bPtr;
//	cout<<"The value of bPtr is "<<*nullptr<<endl; // null pointer cannot be dereferenced

// */	

//*********************************************************************************************	
	/*	
	int a; // a is an integer
	int *aPtr; // aPtr is an int * which is a pointer to an integer

	a = 7; // assigned 7 to a
	aPtr = &a; // assign the address of a to aPtr
	
	cout << "The address of a is " << &a << "\nThe value of aPtr is " << aPtr;
	cout << "\n\nThe value of a is " << a << "\nThe value of *aPtr is " << *aPtr;
	cout << "\n\nShowing that * and & are inverses of " << "each other.\n&*aPtr = " << &*aPtr << "\n*&aPtr = " << *&aPtr << endl;
	cout << "&aPtr  = "<<&aPtr<<endl;
  */
//*********************************************************************************************	
	/*	
	int number = 5;

	cout << "The original value of number is " << number<<endl;
	cout<< "The value after cube is " << cubeByValue( number ); // pass number by value to cubeByValue
	cout << "\nThe new value of number is " << number << endl<<endl;

	
	int number1 = 5;
	cout<<"Pass by reference with pointers"<<endl;
	cout << "The original value of number is " << number1;
	
	cubeByReference( &number1 ); // pass number address to cubeByReference
	cout << "\nThe new value of number is " << number1 << endl;
	*/	
//*********************************************************************************************	
 /*
	 long double number = 0; 

	cout << "The original value of number is " << number;
	for(int i=1; i<=1000000000;i++)
		number=doubleByValue( number ); // pass number by value to cubeByValue
	cout << "\nUsing double by value number is " << number << endl;
*/

//********************************************************************************************
	/*
	int a=3;
	int *aPtr=&a;
	int **Ptr1=&aPtr;
	int ***Ptr2=&Ptr1;
	int ****Ptr3=&Ptr2;
	
	cout<<a<< "  "<< &a<<endl;
	cout<<*aPtr<< "  "<< &*aPtr<<endl;
	cout<<**Ptr1<< "  "<< &**Ptr1<<endl;
	cout<<***Ptr2<< "  "<< &***Ptr2<<endl;
	cout<<****Ptr3<< "  "<< &****Ptr3<<endl;
		
	*/
//***********************************************************************************************
	/*	
	 long double number1 = 0;

	cout << "The original value of number is " << number1;
	for(int i=1; i<=1000000000;i++)
		doubleByReference( &number1 ); // pass number address to cubeByReference
	cout << "\nUsing double by Reference number is " << number1 << endl;

	*/
//***********************************************************************************************

	/*	
	const int arraySize = 10;
	int order; // 1 = ascending, 2 = descending
	int counter; // array index
	int array[ arraySize ] = { 2, -6, 4, 8, 0, 12, 89, 68, 45, 37 };

	cout << "Enter 1 to sort in ascending order,\n"
	<< "Enter 2 to sort in descending order: ";
	cin >> order;
	cout << "\nData items in original order\n";

	// output original array
	for ( counter = 0; counter < arraySize; ++counter )
		cout << setw( 4 ) << array[ counter ];

	// sort array in ascending order; pass function ascending
	// as an argument to specify ascending sorting order
	if ( order == 1 )
	{
		selectionSort( array, arraySize, ascending );
		cout << "\nData items in ascending order\n";
	} // end if

	// sort array in descending order; pass function descending
	// as an argument to specify descending sorting order
	else if(order == 2)
	{
		selectionSort( array, arraySize, descending );
		cout << "\nData items in descending order\n";
	} // end else part of if...else

	cout<<endl;
	// output sorted array
	for ( counter = 0; counter < arraySize; ++counter )
		cout << setw( 4 ) << array[ counter ];

	cout << endl;
	 */	
//*********************************************************************************************

	
} // end main

//*********************************************************************************************
// calculate and return cube of integer argument
int cubeByValue( int n )
{
return n * n * n; // cube local variable n and return result
} // end function cubeByValue

// calculate cube of *nPtr; modifies variable number in main
void cubeByReference( int *nPtr )
{
*nPtr = *nPtr * *nPtr * *nPtr; // cube *nPtr
} // end function cubeByReference
//*********************************************************************************************
int doubleByValue(  long double n )
{
return n + 2; // cube local variable n and return result
} // end function cubeByValue

// calculate cube of *nPtr; modifies variable number in main
void doubleByReference(  long double *nPtr )
{
*nPtr = *nPtr + 2 ; // cube *nPtr
} // end function cubeByReference

//*********************************************************************************************
// multipurpose selection sort; the parameter compare is a pointer to
// the comparison function that determines the sorting order
void selectionSort( int work[], const int size,bool (*compare) ( int, int ))
{
	int smallestOrLargest; // index of smallest (or largest) element
	// loop over size - 1 elements
	for ( int i = 0; i < size - 1; ++i )
	{
		smallestOrLargest = i; // first index of remaining vector

		// loop to find index of smallest (or largest) element
		for ( int index = i + 1; index < size; ++index )
			if ( (*compare)( work[ index ], work[ smallestOrLargest ] ))
				smallestOrLargest = index;
			swap( &work[ smallestOrLargest ], &work[ i ] );
	} // end if
} // end function selectionSort

// swap values at memory locations to which
// element1Ptr and element2Ptr point
void swap( int * const element1Ptr, int * const element2Ptr )
{
	int hold = *element1Ptr;
	*element1Ptr = *element2Ptr;
	*element2Ptr = hold;
} // end function swap

// determine whether element a is less than
// element b for an ascending order sort
bool ascending( int a, int b )
{
	return a < b; // returns true if a is less than b
} // end function ascending

bool descending( int a, int b )
{
	return a > b; // returns true if a is greater than b
} // end function descending
//*****************************************************************************************
