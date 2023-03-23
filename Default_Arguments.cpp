#include <iostream>

using namespace std;


// function prototype that specifies default arguments
int boxVolume( int length=4, int width = 7, int height= 3 );
//int boxVolume( int length , int width =1, int height=9 );
//int boxVolume( int length=1, int width, int height   ); //compilation error

int main()
{

//***************************************************************************
// /*
// Using default arguments.
	
	// no arguments--use default values for all dimensions
	cout << "The default box volume is: " << boxVolume();
	
	// specify length; default width and height
	cout << "\n\nThe volume of a box with length 10,\n"
	<< "width 7 and height 3 is: " << boxVolume( 10 ) ;
	
	// specify length and width; default height
	cout << "\n\nThe volume of a box with length 10,\n"
	<< "width 5 and height 3 is: " << boxVolume( 10, 5 );

	// specify all arguments
	cout << "\n\nThe volume of a box with length 10,\n"
	<< "width 5 and height 2 is: " << boxVolume( 10, 5, 2 )	<< endl;
/// */
}
//***************************************************************************
// function boxVolume calculates the volume of a box
int boxVolume(  int width, int height,int length )
{
	return length * width * height;
} // end function boxVolume

//**************************************************************************



