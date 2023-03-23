// Definition of function template maximum.
#include <iostream>
using namespace std;

template < typename T > 
T maximum( T value1, T value2, T value3 )
{
	T maximumValue = value1; // assume value1 is maximum
	// determine whether value2 is greater than maximumValue
	
	if ( value2 > maximumValue )
		maximumValue = value2;
	// determine whether value3 is greater than maximumValue
	
	if ( value3 > maximumValue )
		maximumValue = value3;
	
	return maximumValue;
} // end function template maximum

// Definition of function template minimum.
template < typename T , typename A, typename B> 
T minimum( T value1, A value2, B value3 )
{
	T minimumValue = value1; // assume value1 is minimum
	// determine whether value2 is smaller than minimumValue
	
	if ( value2 < minimumValue )
		minimumValue = value2;
	// determine whether value3 is smaller than minimumValue
	
	if ( value3 < minimumValue )
		minimumValue = value3;
	
	return minimumValue;
} // end function template minimum

