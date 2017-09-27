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
		if (0 <= p < N){
			if (p == l->last + 1){
				l->arr[p] = x;
				l->last++;
			}
			else{
				if (p < l->last){
					for(int i = l->last; i >= p; i --){
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

void task1(){
	list *l = new list;
	l->last = -1;
	insert(l, 1, 0);

	cout <<"last: " <<  l->last << endl;
	for (int i = 0; i <= l->last; i++){
		cout << l->arr[i] << " ";
	}
	cout << endl;

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