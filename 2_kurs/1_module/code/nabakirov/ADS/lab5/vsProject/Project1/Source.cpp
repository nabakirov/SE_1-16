#include <iostream>
#include <string>
using namespace std;

const string INIT = "queue is initialized\n";
const string EMPTY = "queue is empty\n";

struct Queue {
	int element;
	Queue *next;
};
Queue *last = NULL, *first = NULL;
int temp = 0;
int cnt = 0;

int getINT() {
	int k;
	int i = 0;
	do {
		if (i > 0) {
			cout << "only integer!\n";
		}
		i++;
		cin.clear();
		cin.ignore(cin.rdbuf()->in_avail());
		cin >> k;

	} while (cin.fail());
	return k;
}


int add(Queue *o, Queue *k, int element) {
	Queue *toAdd = new Queue;
	if (last == NULL || first == NULL) {
		toAdd->element = element;
		toAdd->next = NULL;
		last = toAdd;
		first = toAdd;
		cnt++;
		return toAdd->element;
	}
	
	toAdd->element = element;
	toAdd->next = last->next;
	last->next = toAdd;
	last = toAdd;
	cnt++;
	return toAdd->element;
	
}

int del(Queue *k) {
	Queue *toDel = first;
	first = first->next;
	int deleted = toDel->element;
	delete toDel;
	cnt--;
	return deleted;
}

void print(Queue *j) {
	Queue *i = first;
	cout << "\nqueue: ";
	while (i != NULL) {
		cout << i->element << " ";
		i = i->next;
	}
	i = NULL;
	delete i;
	cout << endl;
}

Queue* search_val(int element, Queue * k) {
	Queue*found = first;
	while (found != NULL) {
		if (found->element == element) {
			return found;
		}
		temp++;
		found = found->next;
	}
	found = NULL;
	return found;
}

Queue *search_pos(int element, Queue * first) {
	Queue* found = first;
	while (found != NULL) {
		if (temp == element) {
			return found;
		}
		temp++;
		found = found->next;
	}
	found = NULL;
	return found;
}

void delAll(Queue * n, Queue* l) {
	while (first != NULL) {
		Queue* del = first;
		first = first->next;
		delete del;
	}
	last = first;
	cnt = 0;
}


int main() {
	
	int count = 0;
	
	int action;
	do {
		cout << "\t0 - exit\n";
		cout << "\t1 - print\n";
		cout << "\t2 - append\n";
		cout << "\t3 - delete\n";
		cout << "\t4 - search by value\n";
		cout << "\t5 - search by position\n";
		cout << "\t6 - delete queue\n";
		cout << "\t7 - length of queue\n";

		action = getINT();
		if (action == 0) {
			break;
		}
		else if (action == 1) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				print(first);
			}
		}
		else if (action == 2) {
			int element = getINT();
			int t = add(first, last, element);
			cout << t << endl;
		}
		else if (action == 3) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				int deleted = del(first);
				cout << "deleted element " << deleted << endl;

			}
		}
		else if (action == 4) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				int element = getINT();
				Queue* found = search_val(element, first);
				if (found == NULL) {
					cout << "element not found\n";
				}
				else {
					cout << "found element: " << found->element << " index: " << temp << endl;
				}
				temp = 0;
			}
		}
		else if (action == 5) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				int element = getINT();
				if (element < cnt && element >= 0) {
					Queue*found = search_pos(element, first);
					if (found == NULL) {
						cout << "element not found\n";
					}
					else {
						cout << "found element: " << found->element << " index: " << temp << endl;
					}
					temp = 0;
				}
				else {
					cout << "position out of range " << cnt - 1 << endl;
				}
			}
		}
		else if (action == 6) {
			if (first != NULL) {
				delAll(first, last);
			}
			cout << EMPTY;
		}
		else if (action == 7) {
			cout << "length: " << cnt << endl;
		}
	} while (action != 0);
	
	return 0;
}