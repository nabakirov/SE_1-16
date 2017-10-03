#include <iostream>
using namespace std;

struct List {
	int element;
	List *next;
	int index;
};

List *Top = NULL;
int I = -1;

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

void push() {
	I++;
	cout << "input element: ";
	int el = getINT();
	List *l = new List;
	l->element = el;
	l->index = I;
	l->next = Top;
	Top = l;

	cout << "pushed element: " << l->element << endl;
}
void del() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	int ind;
	cout << "delete by\t1-value\n\t\t2-index\n";
	int k = getINT();
	if (k != 1 && k != 2) {
		cout << "incorrect choice!\n";
		return;
	}
	bool found = false;
	List *l = Top;
	if (k == 1) {
		cout << "input value: ";
		int val = getINT();
		for (int i = 0; i <= I; i++) {
			if (l->element == val) {
				ind = l->index;
				found = true;
				break;
			}
			l = l->next;
		}
	}
	else {
		cout << "input index: ";
		ind = getINT();
		found = true;
	}
	if (found) {
		l = Top;
		int x, p;
		List *toDel;
		p = l->element;
		for (int i = 0; i <= I; i++) {
			if (l->index == ind) {
				break;
			}
			x = l->next->element;
			l->next->element = p;
			p = x;
			l = l->next;
		}
		I--;
		toDel = Top;
		Top = Top->next;
		delete toDel;
	}
	else {
		cout << "element not found!\n";
		return;
	}
}



void print() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	List *l = Top;
	for (int i = 0; i <= I; i++) {
		cout << "\tindex: " << l->index << "\n\telement: " << l->element << "\n-----------\n";
		l = l->next;
	}
	delete l;
}
void s_val() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	cout << "input value: ";
	int val = getINT();
	List *l = Top;
	for (int i = 0; i <= I; i++) {
		if (l->element == val) {
			cout << "index of found element: " << l->index << endl;
		}
		l = l->next;
	}
	delete l;
}
void s_ind() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	cout << "input index: ";
	int ind = getINT();
	List *l = Top;
	for (int i = 0; i <= I; i++) {
		if (l->index == ind) {
			cout << "element of found index: " << l->element << endl;
		}
		l = l->next;
	}
	delete l;
}

void delAll() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	for (int i = 0; i <= I; i++) {
		List *l = Top;
		Top = l->next;
		delete l;
	}
	Top = NULL;
	I = -1;
	cout << "list is clean\n";
}
void size() {
	if (I == -1) {
		cout << "list is empty!\n";
		return;
	}
	cout << "list size: " << I + 1 << endl;
}

void pop() {
	List *l = Top;
	int x, p;
	List *toDel;
	p = l->element;
	for (int i = 0; i < I; i++) {
		x = l->next->element;
		l->next->element = p;
		p = x;
		l = l->next;
	}
	I--;
	toDel = Top;
	Top = Top->next;
	delete toDel;
}

int main() {

	int k;
	do {
		cout << "\t1-push\n\t2-delete by\n\t3-print\n\t4-search element by value\n\t5-search element by index\n\t6-delete queue\n\t7-size\n\t8-pop\n\t0-exit\n";
		k = getINT();

		switch (k)
		{
		case 1:
			push();
			cout << endl;
			break;
		case 2:
			del();
			cout << endl;
			break;
		case 3:
			print();
			cout << endl;
			break;
		case 4:
			s_val();
			cout << endl;
			break;
		case 5:
			s_ind();
			cout << endl;
			break;
		case 6:
			delAll();
			cout << endl;
			break;
		case 7:
			size();
			cout << endl;
			break;
		case 8:
			pop();
			break;
		default:
			break;
		}
	} while (k != 0);
}