#include <iostream>
#include<cmath>
using namespace std;
int main()


{
	int i, N = 0, a[1000], cnt = 0;
	cout << "input N=";
	cin >> N;
	for (i = 0; i < N; i++)
	{
		a[i] = i + 1;
		cout << "a[" << i << "]=" << a[i] << endl;
		if (i % 2 == 0){
			if (i + 1 % 2 != 0){
				cnt++;
			}
		}
	}
	cout << "Quantity of numbers = " << cnt - 1 << endl;
	system("pause");
	return 0;
}