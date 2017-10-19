#include <iostream>
#include <string>
using namespace std;


const string EMPTY = "list is empty\n";

struct Node {
	int element;
	Node *next;
};



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


int add(Node *&first, int element) {
	Node *toAdd = new Node;
	if (first == NULL) {
		toAdd->element = element;
		toAdd->next = NULL;
		first = toAdd;
		return toAdd->element;
	}

	toAdd->element = element;
	toAdd->next = first->next;
	first->next = toAdd;
	first = toAdd;
	return toAdd->element;

}

int del(Node *&first) {
	Node *toDel = first;
	first = first->next;
	int deleted = toDel->element;
	delete toDel;
	return deleted;
}

void print(Node *first) {
	Node *i = first;
	cout << "\nqueue: ";
	while (i != NULL) {
		cout << i->element << " ";
		i = i->next;
	}
	i = NULL;
	delete i;
	cout << endl;
}

Node* search_val(Node *&first, int element, int &temp) {
	Node*found = first;
	temp = 0;
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

Node *search_pos(Node *&first, int element, int &temp) {
	Node* found = first;
	temp = 0;
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

void delAll(Node *&first) {
	while (first != NULL) {
		Node* del = first;
		first = first->next;
		delete del;
	}
}



int main() {
	Node *first = NULL;
	int temp = 0;

	int action;
	do {
		cout << "\t0 - exit\n";
		cout << "\t1 - print\n";
		cout << "\t2 - insert after value\n";
		cout << "\t3 - insert to index\n";
		cout << "\t4 - delete by value\n";
		cout << "\t5 - delete by index\n";
		cout << "\t6 - search by value\n";
		cout << "\t7 - search by position\n";
		cout << "\t8 - delete list\n";
		cout << "\t9 - length of list\n";

		action = getINT();
		//exit
		if (action == 0) {
			break;
		}
		//print
		else if (action == 1) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				print(first);
			}
		}
		//insert after value
		else if (action == 2) {
			cout << "element: ";
			int element = getINT();
			cout << "value in list: ";
			int value = getINT();
			Node *f_value = search_val(first, value, temp);
			if (f_value == NULL) {
				cout << "value in list not found\n";
				break;
			}
			else {
				int t = add(f_value, element);
				cout << "inserted element: " <<t << endl;
			}
			
		}
		//insert to index
		else if (action == 3) {
			cout << "element: ";
			int element = getINT();
			cout << "index: ";
			int ind = getINT();
			if (ind < 0) {
				cout << "position must be positive " << endl;
				break;
			}
			Node *f_value = search_pos(first, ind, temp);
			if (f_value == NULL) {
				int c;
				
				do {
					cout << "index is bigger to last element's index\nWhould you like to insert to the last position?(1/0)\n";
					c = getINT();
					if (c == 0) {
						break;
					}
					else if(c == 1) {
						Node *el = search_pos(first, temp, temp);
						int t = add(el, element);
						cout << "inserted element: " << t << endl;
						break;
					}
				} while (c != 1 || c != 0);
			}
			else {
				int t = add(f_value, element);
				cout << "inserted element: " << t << endl;
			}

		}
		//delete by value
		else if (action == 4) {
			if (first == NULL) {
				cout << EMPTY;
				break;
			}
			cout << "element: ";
			int element = getINT();
			Node *f_value = search_val(first, element, temp);
			if (f_value == NULL) {
				cout << "value in list not found\n";
				break;
			}
			else {
				int t = del(f_value);
				cout << "deleted element: " << t << endl;
			}
		}
		//delete by index
		else if (action == 5) {
			if (first == NULL) {
				cout << EMPTY;
				break;
			}
			cout << "index: ";
			int element = getINT();
			if (element >= 0) {
				Node *f_value = search_pos(first, element, temp);
				if (f_value == NULL) {
					cout << "value in list not found\n";
					break;
				}
				else {
					int t = del(f_value);
					cout << "deleted element: " << t << endl;
				}
			}
			else {
				cout << "position must be positive " << endl;
			}
		}
		//search by value
		else if (action == 6) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				int element = getINT();
				Node* found = search_val(first, element, temp);
				if (found == NULL) {
					cout << "element not found\n";
				}
				else {
					cout << "found element: " << found->element << " index: " << temp << endl;
				}
				temp = 0;
			}
		}
		//search by position
		else if (action == 7) {
			if (first == NULL) {
				cout << EMPTY;
			}
			else {
				int element = getINT();
				if (element >= 0) {
					Node*found = search_pos(first, element, temp);
					if (found == NULL) {
						cout << "element not found\n";
					}
					else {
						cout << "found element: " << found->element << " index: " << temp << endl;
					}
					temp = 0;
				}
				else {
					cout << "position must be positive " << endl;
				}
			}
		}
		//delete list
		else if (action == 8) {
			if (first != NULL) {
				delAll(first);
			}
			cout << EMPTY;
		}
		//length of list
		else if (action == 9) {
			Node *pv = first;
			int count = 0;
			while (pv != NULL) {
				count++;
				pv = pv->next;
			}
			cout << "length: " << count << endl;
			pv = NULL;
			delete pv;
		}
	} while (action != 0);

	return 0;
}


