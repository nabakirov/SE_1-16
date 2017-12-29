#include <iostream>
using namespace std;
int main(){
	setlocale(0, "");
	int a[8], i, c = 0, sum = 0;
	cout << "input c° " << endl;
	for (i = 0; i < 7; i++)
	{
		cout << i + 1 << " day c°=";
		cin >> a[i];
		if (a[i] < 0){
			c++;
		}
		sum += a[i];
	}
	cout << "the c° was lower than 0| " << c << " times\n";
	cout << "the average  temperature is " << sum / 7 << endl;
	system("pause");
	return 0;
}