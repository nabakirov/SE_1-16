#include <iostream>
using namespace std;
const int N = 30;

struct list{
	int arr[N];
	int last;
};

int insert(list *l, int x, int p){
	if (l->last >= N){
		cout << "list is full" << endl;
		return 0;
	}
	else{
		if (p >= 0 && p < N){
			if (p == l->last + 1){
				l->arr[p] = x;
				l->last++;
			}
			else{
				if (p <= l->last){
					for (int i = l->last; i >= p; i--){
						l->arr[i + 1] = l->arr[i];
					}
					l->arr[p] = x;
					l->last++;
				}
				else{
					l->last++;
					l->arr[l->last] = x;
				}
			}
		}
		else{
			cout << "position argument out of range" << endl;
		}
	}
}
void del(list *l, int p){
	if (p >= 0 && p < N){
		for (int i = p; i < l->last; i++){
			l->arr[i] = l->arr[i + 1];
		}
		l->last--;
		l->arr[p] = NULL;
	}
	else{
		cout << "position argument out of range" << endl;
	}
}

int find_in(list *l, int pos = NULL, int val = NULL){
	if (pos != NULL){
		if (pos >= 0 && pos < N){
			return l->arr[pos];
		}
		else{
			cout << "position argument out of range" << endl;
		}
	}
	else if (val != NULL){
		for (int i = 0; i <= l->last; i++){
			cout << l->arr[i] << endl;
			if (l->arr[i] == val){
				return i;
			}
		}
	}
	else{
		return NULL;
	}
}

void task1(){
	list *l = new list;
	l->last = -1;
	for (int i = 0; i < N; i++){
		l->arr[i] = NULL;
	}
	for (int i = 0; i < 30; i++){
		insert(l, rand(), rand() % 40);
	}
	
	

	cout << "last: " << l->last << endl;
	for (int i = 0; i <= l->last; i++){
		cout << i << ": " << l->arr[i] << endl;
	}
	for (int i = 0; i < 30; i++){
		int a;
		int ran = rand();
		a = find_in(l, NULL, ran);
		cout << "random number: " << NULL << endl;
		if (a != NULL){
			cout << "found: " << a << endl;
		}
		else{
			cout << "give positoin or value argument" << endl;
		}
	}
	cout << endl;
	system("pause");
}


int main(){
	short task;
	cin >> task;
	if (task == 1){
		task1();
	}
	else if (task == 2){
		return 0;
	}
	else{
		cout << "invalid input";
	}

}
