#include <iostream>
#include <stdlib.h>
using namespace std;
const int N = 30;
const int empty = -9999;

struct list{
	int arr[N];
	int last;
};

int insert(list *l, int x, int p){
	if (l->last >= N){
		cout << "list is full" << endl;
	}
	else{
		if (p >= 0 && p < N){
			if (p > l->last){
				l->arr[l->last + 1] = x;
				l->last++;
				return l->arr[l->last];
			}
			else{
				for(int i = l->last; i >= p; i --){
					l->arr[i + 1] = l->arr[i];
				}
				l->arr[p] = x;
				l->last++;	
				return l->arr[p];
			}
		}
		else{
			cout << "position: " << p <<" out of range " << N << endl;
			return empty;
		}
		
	}
}

int del(list *l, int p){
	if (p <= l->last and p >= 0){
		int delEL;
		delEL = l->arr[p];
		for (int i = p; i < l->last; i++){
			l->arr[i] = l->arr[i + 1];
		}
		l->arr[l->last] = empty;
		return delEL;
	}
	else{
		cout << "position: " << p <<" out of range " << l->last << endl;
		return empty;
	}
}

int s_val(list *l, int v){
	if (l->last != empty){
		for(int i = 0; i < l->last; i++){
			if (l->arr[i] == v){
				return i;
			}
		}
		cout << "value: " << v <<" not in the list"<< endl;
		return empty;
	}
	cout << "list is empty" << endl;
	return empty;

}
int s_p(list *l, int p){
	if (l->last != empty){
		if (p >= 0 && p <= l->last){
			return l->arr[p];
		}
		cout << "position: " << p <<" out of range " << l->last << endl;
		return empty;
	}
	cout << "list is empty" << endl;
	return empty;
}

void 

void task1(){
	list *l = new list;
	l->last = empty;
	for (int i = 0; i < N; i++){
		l->arr[i] = empty;
	}
	int choose;
	cout << "choose what to do:\n\t1- push element\n\t2- delete element\n\t3- search element by value\n\t4-search element by index\n";
	cin >> choose;
	switch (choose){
		case 1: 
	}
	for(int i = 0; i < 30; i++){
		int a;
		a = insert(l, rand(), rand() %30);
		if (a != empty){
			cout << a << endl;
		}
	}
	// int length;
	// cin >> length;
	// for(int i = 0; i < length; i++){
	// 	int a;
	// 	cin >> a;

	// }

	// cout <<"last: " <<  l->last << endl;
	// for (int i = 0; i <= l->last; i++){
	// 	cout << l->arr[i] << " ";
	// }
	// cout << endl;

}



int main(){
	short task;
	cin >> task;
	if (task == 1){
		task1();
	}
	else{
		cout << "invalid input";
	}
	
}