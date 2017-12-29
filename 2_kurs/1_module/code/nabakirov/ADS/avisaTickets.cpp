#include <iostream>
#include <map>

using namespace std;

bool curcled = false;

struct List {
    string destination;
    int flightNumber;
    string name;
    string date;
	List *next;
	List *prev;

};

map<int, int> free;


int getINT() {

	int k;
//	int i = 0;
//	do {
//		if (i > 0) {
//			cout << "only integer!\n";
//		}
//		i++;
//		cin.clear();
//		cin.ignore(cin.rdbuf()->in_avail());
//		cin >> k;
//
//	} while (cin.fail());
    cin >> k;
	return k;
}

string getString(){

    string k;
    cin >> k;
    return k;
}

void printFiltered(List*front, List*back, int number, string date) {
	if (front == NULL || back == NULL) {
		cout << "list is empty\n";
		return;
	}
	List*temp = front;
	List *t;
	if (curcled == true) {
		t = front;
		cout << "curcled list\n";
		cout << "front->next " << front->next << endl;
		cout << "back        " << back << endl;
		cout << "back->prev  " << back->prev << endl;
		cout << "front       " << front << endl;
	}

	else { t = NULL; }
	cout << "Destination\t\tFlight Number\t\tName\t\tData" << endl;
	do {
            if(temp->flightNumber == number && temp->date == date){
                cout << temp->destination << "\t\t\t" << temp->flightNumber << "\t\t\t" << temp->name << "\t\t" << temp->date << endl;
            }

		temp = temp->prev;
	} while (temp != t);
	cout << endl;
}

void print(List*front, List*back) {
	if (front == NULL || back == NULL) {
		cout << "list is empty\n";
		return;
	}
	List*temp = front;
	List *t;
	if (curcled == true) {
		t = front;
		cout << "curcled list\n";
		cout << "front->next " << front->next << endl;
		cout << "back        " << back << endl;
		cout << "back->prev  " << back->prev << endl;
		cout << "front       " << front << endl;
	}

	else { t = NULL; }
	cout << "Destination\t\tFlight Number\t\tName\t\tData" << endl;
	do {
		cout << temp->destination << "\t\t\t" << temp->flightNumber << "\t\t\t" << temp->name << "\t\t" << temp->date << endl;
		temp = temp->prev;
	} while (temp != t);
	cout << endl;
}

//List* insert_front(List*&front, List*&back, int item) {
//	List*temp = new List;
//	if (front == NULL || back == NULL) {
//
//		temp->item = item;
//		temp->prev = NULL;
//		temp->next = NULL;
//		front = temp;
//		back = temp;
//	}
//	else {
//		temp->item = item;
//		temp->prev = front;
//		temp->next = front->next;
//		front->next = temp;
//		front = temp;
//		if (curcled) {
//			back->prev = front;
//		}
//
//	}
//	return temp;
//}
List* insert_back(List*&front, List*&back, string destination, int flightNumber, string name, string date) {
	List*temp = new List;
	if (front == NULL || back == NULL) {
		temp->destination = destination;
		temp->flightNumber = flightNumber;
		temp->name = name;
		temp->date = date;
		temp->next = NULL;
		temp->prev = NULL;
		back = temp;
		front = temp;
	}
	else {
		temp->destination = destination;
		temp->flightNumber = flightNumber;
		temp->name = name;
		temp->date = date;
		temp->next = back;
		temp->prev = back->prev;
		back->prev = temp;
		back = temp;

		if (curcled) {
			front->next = back;
		}


	}

	return temp;
}
List* search_by_value(List*&front, int& index, int flightNumber, string name, string date) {
	if (front != NULL) {
		List* temp = front;
		index = 0;
		List *t;
		if (curcled == true) {t = front;}
		else { t = NULL; }
		do {
			if (temp->flightNumber == flightNumber && temp->name == name && temp->date == date) {
				return temp;
			}
			temp = temp->prev;
			index++;
		} while (temp != t);
		return NULL;
	}
	return NULL;
}
List* search_by_position(List*&front, int position, int& index) {
	if (front != NULL) {
		List* temp = front;
		index = 0;
		List *t;

		do {
			if (index == position) {
				return temp;
			}
			temp = temp->prev;
			index++;
		} while (true || temp != NULL);
		return NULL;
	}
	return NULL;
}

//List* insert_before(List*&front, List*&back, int item, List*&temp) {
//	if (temp->next == NULL) {
//		return insert_front(front, back, item);
//	}
//	else {
//		List*inserted = new List;
//		inserted->item = item;
//		temp->next->prev = inserted;
//		inserted->next = temp->next;
//		temp->next = inserted;
//		inserted->prev = temp;
//		return inserted;
//	}
//}
//List* insert_after(List*&front, List*&back, int item, List*&temp) {
//	if (temp->prev == NULL) {
//		return insert_back(front, back, item);
//	}
//	List* inserted = new List;
//	inserted->item = item;
//	temp->prev->next = inserted;		cout << "3 - delete\n";
//		cout << "4 - search\n";

//	inserted->prev = temp->prev;
//	temp->prev = inserted;
//	inserted->next = temp;
//	return inserted;
//}
//List* insert_before_by_value(List*&front, List*&back, int item, int value) {
//	if (front == NULL || back == NULL) {
//		return NULL;printFiltered
//	}
//	int index;
//	List* temp = search_by_value(front, value, index);
//	if (temp == NULL) {
//		return NULL;
//	}
//	if (value == front->item) {
//		return insert_front(front, back, item);
//	}
//	return insert_before(front, back, item, temp);
//}
//List* insert_before_by_position(List*&front, List*&back,int item, int position) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//		int index;
//		List* temp = search_by_position(front, position, index);
//		if (temp == NULL) {
//			return NULL;
//		}
//		if (position == 0) {
//			return insert_front(front, back, item);
//		}
//
//		return insert_before(front, back, item, temp);
//
//}
//List* insert_after_by_value(List*&front, List*&back, int item, int value) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_value(front, value, index);
//	if (temp == NULL) {
//		return NULL;
//	}
//	if (value == back->item) {
//		return insert_back(front, back, item);
//	}
//	return insert_after(front, back, item, temp);
//}
//List* insert_after_by_position(List*&front, List*&back, int item, int position) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_position(front, position, index);
//	if (temp == NULL) {
//		return NULL;
//	}
//	if (temp == back) {
//		return insert_back(front, back, item);
//	}
//	return insert_after(front, back, item, temp);
//}

void insert(List*& front, List*& back) {
	int action;
	do {

		cout << "0 - up\n";
//		cout << "1 - insert to front\n";
		cout << "1 - insert to back\n";
//		cout << "3 - insert before element by value\n";
//		cout << "4 - insert before element by position\n";
//		cout << "5 - insert after element by value\n";
//		cout << "6 - insert after element by position\n";
		action = getINT();
		string destination;
        int flightNumber;
        string name;
        string date;
		List* inserted;
		List* exist;
		int index;
		switch (action) {
		case 0:
			return;
//		case 1:
//			cout << "enter element: ";
//			item = getINT();
//
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
//
//			inserted = insert_front(front, back, item);
//			cout << "inserted element: " << inserted->item << endl;
//			print(front, back);
//			break;
		case 1:
			cout << "enter destination point: ";
			destination = getString();
			cout << "enter flight number: ";
			flightNumber = getINT();
			cout << "enter your name: ";
			name = getString();
			cout << "enter fight date: ";
			date = getString();
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
			inserted = insert_back(front, back, destination, flightNumber, name, date);
			cout << "inserted element: " << inserted->flightNumber << endl;
			print(front, back);
			break;
//		case 3:
//			cout << "enter element: ";
//			item = getINT();
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
//			cout << "enter value: ";
//			value = getINT();
//			inserted = insert_before_by_value(front, back, item, value);
//			if (inserted == NULL) {
//				cout << "element not found\n";
//			}
//			else {
//				cout << "inserted element: " << inserted->item << endl;
//				print(front, back);
//			}
//printFiltered
//			break;
//		case 4:
//			cout << "enter element: ";
//			item = getINT();
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
//			cout << "enter position:" ;
//			position = getINT();
//			inserted = insert_before_by_position(front, back, item, position);
//			if (inserted == NULL) {
//				cout << "element not found\n";
//			}
//			else {
//				cout << "inserted element: " << inserted->item << endl;
//				print(front, back);
//			}
//			break;
//		case 5:
//			cout << "enter element: ";
//			item = getINT();
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
//			cout << "enter value: ";
//			value = getINT();
//			inserted = insert_after_by_value(front, back, item, value);
//			if (inserted == NULL) {
//				cout << "element not found\n";
//			}
//			else {
//				cout << "inserted element: " << inserted->item << endl;
//				print(front, back);
//			}
//			break;
//		case 6:
//			cout << "enter element: ";
//			item = getINT();
//			exist = search_by_value(front, item, index);
//			if (exist) {
//				cout << "only unique\n";
//				break;
//			}
//			cout << "enter position:";
//			position = getINT();
//			inserted = insert_after_by_position(front, back, item, position);
//			if (inserted == NULL) {
//				cout << "element not found\n";
//			}
//			else {
//				cout << "inserted element: " << inserted->item << endl;
//				print(front, back);
//			}
//			break;
		default:
			cout << "unknown command\n";
		}
	} while (true);
}

int del(List*&front, List*&back, List*&temp) {
	int deleted;
	deleted = temp->flightNumber;
	List* toDel;
	if (temp->next == NULL && temp->prev == NULL) {
		toDel = temp;
		front = NULL;
		back = NULL;
		delete toDel;
		return deleted;
	}
	else if (temp->next != NULL && temp->prev == NULL) {
		toDel = temp;
		temp->next->prev = NULL;
		back = temp->next;

		delete toDel;
		return deleted;
	}
	else if (temp->next == NULL && temp->prev != NULL) {
		toDel = temp;
		temp->prev->next = NULL;
		front = temp->prev;

		delete toDel;
		return deleted;
	}
	else {
		if (curcled) {
			if (temp == front) {
				if (front == front->prev) {
					curcled = false;
					front = NULL;
					back = NULL;
					delete temp;
					return deleted;

				}
				front = front->prev;

			}
			else if (temp == back){
				if (back == back->next) {
					curcled = false;
					front = NULL;
					back = NULL;
					delete temp;
					return deleted;
				}
				back = back->next;
			}
		}
		toDel = temp;
		temp->next->prev = temp->prev;
		temp->prev->next = temp->next;
		temp = NULL;
		delete temp;
		return deleted;


	}
}

void search(List*& front, List*& back) {
	if (front == NULL) {
		cout << "list is empty\n";
		return;
	}
	int action;
	int index;
	while (true) {
		cout << "0 - up\n";
		cout << "1 - by value\n";
		cout << "2 - by position\n";
		action = getINT();
		int flightNumber;
		string name, date;

		int position;
		List* temp;
		switch (action) {
		case 0:
			return;
		case 1:
			cout << "enter flight number: ";
            flightNumber = getINT();
            cout << "enter your name: ";
            name = getString();
            cout << "enter fight date: ";
            date = getString();
			temp = search_by_value(front, index, flightNumber, name, date);
			if (temp != NULL) {
				cout << "Destination\t\tFlight Number\t\tName\t\tData" << endl;
                cout << temp->destination << "\t\t\t" << temp->flightNumber << "\t\t\t" << temp->name << "\t\t" << temp->date << endl;

			}
			else {
				cout << "element not found\n";
			}
			break;
		case 2:
			position = getINT();
			temp = search_by_position(front, position, index);
			if (temp != NULL) {
				cout << "Destination\t\tFlight Number\t\tName\t\tData" << endl;
                cout << temp->destination << "\t\t\t" << temp->flightNumber << "\t\t\t" << temp->name << "\t\t" << temp->date << endl;

			}
			else {
				cout << "element not found\n";
			}
			break;
		default:
			cout << "invalid comand\n";
			break;
		}

	}
}


int del_by_value(List*&front, List*&back, int flightNumber, string name, string date) {
	int index, deleted;
	List* temp = search_by_value(front, index, flightNumber, name, date);
	if (temp != NULL) {
		deleted = del(front, back, temp);
		return deleted;
	}
	else {
		return NULL;
	}
}
int del_by_position(List*&front, List*&back, int position) {
	int index, deleted;
	List* temp = search_by_position(front, position, index);
	if (temp != NULL) {
		deleted = del(front, back, temp);
		return deleted;
	}
	else {
		return NULL;
	}
}
//int del_before_by_value(List*&front, List*&back, int value) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_value(front, value, index);
//	if (temp != NULL) {
//		if (temp->next != NULL) {
//			temp = temp->next;
//			int deleted = del(front, back, temp);
//			return deleted;
//		}
//		return NULL;
//	}
//	return NULL;
//}
//int del_before_by_position(List*&front, List*&back, int position) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_position(front, position, index);
//	if (temp != NULL) {
//		if (temp->next != NULL) {
//			temp = temp->next;
//			int deleted = del(front, back, temp);
//			return deleted;
//		}
//		return NULL;
//	}
//	return NULL;
//}
//int del_after_by_value(List*&front, List*&back, int value) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_value(front, value, index);
//	if (temp != NULL) {
//		if (temp->prev != NULL) {
//			temp = temp->prev;
//			int deleted = del(front, back, temp);
//			return deleted;
//		}
//		return NULL;
//	}
//	return NULL;
//}
//int del_after_by_position(List*&front, List*&back, int position) {
//	if (front == NULL || back == NULL) {
//		return NULL;
//	}
//	int index;
//	List* temp = search_by_position(front, position, index);
//	if (temp != NULL) {
//		if (temp->prev != NULL) {
//			temp = temp->prev;
//			int deleted = del(front, back, temp);
//			return deleted;
//		}
//		return NULL;
//	}
//	return NULL;
//}
//
//
void del_option(List*&front, List*&back) {
	int action;
	while (true) {
		cout << "0 - up\n";
		cout << "1 - by value\nprintFiltered";
		cout << "2 - by position\n";
//		cout << "3 - before by value\n";
//		cout << "4 - before by position\n";
//		cout << "5 - after by value\n";
//		cout << "6 - after by position\n";
		action = getINT();
		string destination;
        int flightNumber;
        string name;
        string date;
		int position;
		int deleted;
		switch (action) {
		case 0:
			return;
		case 1:
			cout << "enter flight number: ";
			flightNumber = getINT();
			cout << "enter your name: ";
			name = getString();
			cout << "enter fight date: ";
			date = getString();
			deleted = del_by_value(front, back, flightNumber, name, date);
			if (deleted == NULL) {
				cout << "element not found\n";

			}
			else {
				cout << "deleted element: " << deleted << endl;
			}
			print(front, back);
			break;
		case 2:
			cout << "enter position: ";
			position = getINT();
			deleted = del_by_position(front, back, position);
			if (deleted == NULL) {
				cout << "element not found\n";

			}
			else {
				cout << "deleted element: " << deleted << endl;
			}
			print(front, back);
			break;
//		case 3://		cout << "4 - search\n";

//			cout << "enter value: ";
//			value = getINT();
//			deleted = del_before_by_value(front, back, value);
//			if (deleted == NULL) {
//				cout << "element not found\n";
//
//			}
//			else {
//				cout << "deleted element: " << deleted << endl;
//			}
//			print(front, back);
//			break;
//		case 4:
//			cout << "enter position: ";
//			position = getINT();
//			deleted = del_before_by_position(front, back, position);
//			if (deleted == NULL) {
//				cout << "element not found\n";
//
//			}
//			else {
//				cout << "deleted element: " << deleted << endl;
//			}
//			print(front, back);
//			break;
//		case 5:
//			cout << "enter value: ";
//			value = getINT();
//			deleted = del_after_by_value(front, back, value);
//			if (deleted == NULL) {
//				cout << "element not found\n";
//
//			}
//			else {
//				cout << "deleted element: " << deleted << endl;
//			}
//			print(front, back);
//			break;
//		case 6:
//			cout << "enter position: ";
//			position = getINT();
//			deleted = del_after_by_position(front, back, position);
//			if (deleted == NULL) {
//				cout << "element not found\n";
//
//			}
//			else {
//				cout << "deleted element: " << deleted << endl;
//			}
//			print(front, back);
//			break;
		}
	}
}
void curcle_it(List*&front, List*&back) {
	front->next = back;
	back->prev = front;
	curcled = true;
}
void uncurcle_it(List*&front, List*&back) {
	front->next = NULL;
	back->prev = NULL;
	curcled = false;
}
void curcle_options(List*&front, List*&back) {
	if (front == NULL || back == NULL) {
		cout << "list is empty\n";
		return;
	}
	int action;
	while (true) {
		cout << "0 - up\n";
		cout << "1 - curcle\n";
		cout << "2 - uncurcle\n";
		action = getINT();
		if (action == 0) {
			return;
		}
		if (action == 1) {
			if (!curcled) {
				curcle_it(front, back);
			}
			else {
				cout << "alredy curcled\n";
			}
			print(front, back);
		}
		else if (action == 2){
			if (curcled){
				uncurcle_it(front, back);
			}
			else {
				cout << "alredy uncurcled\n";
			}

			print(front, back);
		}
	}
}

int main() {
    free[1] = 5;
    free[2] = 5;
    free[3] = 5;

	List * front = NULL;
	List * back = NULL;
	int action;

	do {
		cout << "0 - exit\n";
		cout << "1 - print\n";
		cout << "2 - insert\n";
		cout << "3 - delete\n";
		cout << "4 - search\n";
		cout << "5 - curcle\n";
		cout << "6 - filtered by flight number and date\n";
        string date;
        int number;
		action = getINT();
		switch (action) {
		case 0:
			return 0;
		case 1:
			print(front, back);
			break;
		case 2:
			insert(front, back);
			break;
		case 3:
			del_option(front, back);
			break;
		case 4:
			search(front, back)//		cout << "4 - search\n";
;
			break;
		case 5:
			curcle_options(front, back);
			break;
        case 6:
            cout << "enter flight number: ";
            number = getINT();
            cout << "enter date: ";
            date = getString();
            printFiltered(front, back, number, date);
            break;
		}
	} while (true);
}//		cout << "4 - search\n";



