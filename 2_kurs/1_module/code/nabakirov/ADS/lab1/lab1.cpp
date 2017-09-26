#include <iostream>
using namespace std;
int firts() {
	cout << "input 5 elements of array: ";
	float arr[4];
	for (short i = 0; i < 5; i++) {
		cin >> arr[i];
	}
	float min = arr[0];
	short index = 0;
	for (short i = 1; i < 5; i++) {
		if (arr[i] < min) {
			min = arr[i];
			index = i;
		}
	}
	cout << "min el: " << min << endl;
	cout << "index: " << index;
	cout << endl;


}

int second() {
	cout << "input 10 elements of array: ";
	float arr[10];
	for (short i = 0; i < 10; i++) {
		cin >> arr[i];
	}
	float min = arr[0];
	short index = 0;
	for (short i = 1; i < 10; i++) {
		if (arr[i] <= min) {
			min = arr[i];
			index = i;
		}
	}
	int result = 10 - (index + 1);
	cout << "index of min: " << index << endl;
	cout << "quantity: "<< result<< endl;
}

int third(){
	cout << "input 9 elements of 2 dimentional array: ";
	float arr[3][3];
	for(short i = 0; i < 3; i++){
		for(short j = 0; j < 3; j++){
			cin >> arr[i][j];
		}
	}
	float x[3];
	float min = arr[0][0];
	short min_index = 0;
	float max = arr[0][0];
	short max_index = 0;
	for(short i = 0; i < 3; i++){
		for(short j = 0; j < 3; j++){
			if (arr[i][j] < min){
				min = arr[i][j];
				min_index = i;
			}
			if (arr[i][j] > max){
				max = arr[i][j];
				max_index = i;
			}
		}
	}
	if (max_index != min_index){
		for (short i = 0; i < 3; i++){
			x[i] = arr[min_index][i];
			arr[min_index][i] = arr[max_index][i];
			arr[max_index][i] = x[i];
		}
	}
	
	cout << endl;
	for(short i = 0; i < 3; i++){
		for(short j = 0; j < 3; j++){
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}

}

int fourth(){
	short length;
	cout << "input length of arrray: ";
	cin >> length;

	float *arr = new float[length];
	for (short i = 0; i < length; i++){
		cin >> arr[i];
	}
	float x;
	for(short j = 0; j < length; j++){
		for (short i = 1; i < length; i++){
			if (arr[i - 1] > arr[i]){
				x = arr[i - 1];
				arr[i - 1] = arr[i];
				arr[i] = x;
			}
		}
	}

	cout << endl;
	for(short i = 0; i < length; i++){
		cout << arr[i] << " ";
	}
	
	delete [] arr;
}

int fifth(){
	short length;
	cout << "input length of an array: ";
	cin >> length;
	float *arr = new float[length];
	for(short i = 0; i < length; i++){
		cin >> arr[i];
	}

	
	short min_index = 0;
	short max_index = 0;
	float x;

	for(short i = 1; i < length; i++){
		if(arr[i] < arr[min_index]){
			min_index = i;
		}
		if(arr[i] > arr[max_index]){
			max_index = i;
		}
	}
	x = arr[min_index];
	arr[min_index] = arr[max_index];
	arr[max_index] = x;

	cout << endl;
	for (short i = 0; i < length; ++i)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
	delete [] arr;
}

int main() {
	cout << "choose the task (1 - 5):" << endl;
	short task;
	cin >> task;
	if (task == 1){
		firts();
	}
	else if (task == 2){
		second();
	}
	else if (task == 3){
		third();
	}
	else if (task == 4){
		fourth();
	}
	else if (task == 5){
		fifth();
	}
	else{
		cout << "invalid input";
	}
}