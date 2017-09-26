#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;


int task1(){
	short a;
	short *pointer;
	pointer = &a;
	*pointer = 5;
	cout << "a = " << a << endl;

}
void task2(){
	int x;
	int *pointer = &x;
	int &linker = x;

	*pointer = 10;
	cout << "pointer = " << x << endl;

	linker = 5;
	cout << "reference = " << x << endl;

}
void task3(){
	int x;
	int *pointer = new int;

	pointer = &x;
	*pointer = 5;
	cout << "before: " << x << endl;
	delete pointer;

	*pointer = 10;
	cout << "after: " << *pointer << endl;

}
void task4(){
	int x;
	int *pointer = new int;

	pointer = &x;
	*pointer = 5;
	cout << "before: " << x << endl;
	delete pointer;

	// pointer = new int;
	// *pointer = NULL;
	cout << "after: " << pointer << endl;
}
void task5(){
	int *a = new int;
	*a = 9;
	cout << *a << endl;
}
void task6(){
	srand(time(NULL));
	short length;
	cin >> length;
	short *a = new short[length];
	for(short i = 0; i < length; i++){
		a[i] = rand() % 1000 + 0;
	} 
	for(short i = 0; i < length; i++){
		cout << a[i] << " ";	
	}
	cout << endl;
	
	delete a;
}

int main(){
	short task;
	cin >> task;
	if (task == 1){
		task1();
	}
	else if (task == 2){
		task2();
	}
	else if (task == 3){
		task3();
	}
	else if(task == 4){
		task4();
	}
	else if(task == 5){
		task5();
	}
	else if(task == 6){
		task6();
	}
	else{
		cout << "invalid input";
	}
	
}