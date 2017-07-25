#include "stdafx.h"
extern "C"             //No name mangling
__declspec(dllexport)  //Tells the compiler to export the function
int                    //Function return type     
__cdecl                //Specifies calling convention, cdelc is default, 
					   //so this can be omitted 
//simple test function
IncrementNumber(int number) 
{
	return number + 1;
}

extern "C"
__declspec(dllexport)  //Tells the compiler to export the function
int                    //Function return type     
//a very rough fibonacci calculator (think its working)
Fibonacci(int fibNo)
{
	int a = 1;
	int b = 1;
	int sum = 0;

	for (int i = 0; i < fibNo; i++)
	{
		int temp = a;
		a = b;
		b = temp + b;

		//add one to the sum ie first fib number
		sum += (b + 1);
	}

	return sum;
}