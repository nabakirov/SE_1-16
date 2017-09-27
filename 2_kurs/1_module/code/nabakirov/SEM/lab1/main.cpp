#include <iostream>
#include <string>
#include <sstream>
#include <iostream>
#include <string>
#include <cerrno>
#include <cstdlib>
using namespace std;

void input(double *array, int N){
	for(int i = 0; i < N; i++){
		string a;
		double d;
		cout << "inter the " << i << " element: ";
		cin >> a;
		d = std::wcstod(a, 5)
		// if (a >> d){
		// 	array[i] = d;
		// }
		// else{
		// 	cout << "invalid input";
		// }
	}
}
void find_max(double *arr, int n, double &element, double &index){
	element = arr[0];
	index = 0;
	for(int i = 1; i < n; i++){
		if(arr[i] > element){
			element = arr[i];
			index = i;
		}
	}

}
void find_min(double *arr, int n, double &element, double &index){
	element = arr[0];
	index = 0;
	for(int i = 1; i < n; i++){
		if(arr[i] < element){
			element = arr[i];
			index = i;
		}
	}

}
void output(double min_el, double min_ind, double max_el, double max_ind){
	cout << "max element of the array: " << max_el << endl;
	cout << "max element's index of the array: " << max_ind << endl;
	cout << "min element of the array: " << min_el << endl;
	cout << "max element's index of the array: " << min_ind << endl;
}

int main(){
	int n;
	cout << "input the length of the array";
	cin >> n;
	double *array = new double(n);
	input(array, n);
	double max_el;
	double max_ind;
	double min_el;
	double min_ind;
	find_max(array, n, max_el, max_ind);
	find_min(array, n, min_el, min_ind);
	output(min_el, min_ind, max_el, max_ind);
	return 0;
}