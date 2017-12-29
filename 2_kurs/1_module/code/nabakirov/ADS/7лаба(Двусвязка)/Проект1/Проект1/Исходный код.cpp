#include<iostream>
using namespace std;
struct node{
	int item;
	node *pred;
	node *next;

};
int coun = 0;
bool q1 = false;
int get();
void sort2(node *&front, node *&back);
void sort(node *&front, node *&back);
void circle(node *&front, node *&back);
void uncircle(node *&front, node *&back);
void add( node *&front,node *&back);
void print(node *&front,node *&back);
void delet(node *&front, node *&back);
void clear(node *&front);
void count(node *&front);
void searchp(int i, node *&front);
void searchv(int i, node *&front);
int main(){
	node *front = NULL;
	node *back = NULL;
	int v = -1, v1 = -1, v2 = -1, con = -1;
		do{
			cout << "\t\tChoose action:\n1-Add\n2-Delete\n3-Search by position\n4-Search by element\n5-Print\n6-Count\n7-Clear\n8-Circle\n9-Uncircle\n10-Sort\n0-Exit\n";
			cout << "\tAction:";
			v1 = get();
			if (v1<-1 || v1>10){ cout << "Choose from 0-10..." << endl; continue; }
			if (v1 == 1){
				add( front, back);
				if (coun != 0){
				q1 = true;}
			}
			if (q1 == false){ cout << "The list is empty push first ..." << endl; continue; }
			if (v1 == 2){
				delet(front,back);
			
				if (coun == 0){
					q1 = false;
				}
			}
			if (v1 == 3){
				cout << "Enter position p=";
				int i;
				do{
					i = get();
					if (i < 0){
						cout << "Enter positive number\np=";
					}
				} while (i < 0);
				searchp(i, front);
			}
			if (v1 == 4){
				cout << "Enter value x=";
				int i = get();
				searchv(i, front);}
			if (v1 == 5){ print(front,back); }
			if (v1 == 6){ count(front); }
			if (v1 == 7){
				clear(front); back = NULL;
				coun = 0;
				q1 = false;
			}
			if (v1 == 8){ circle(front, back); }
			if (v1 == 9){ uncircle(front, back);}
			if (v1 == 10){ if (back->next == NULL){ sort(front, back); } else sort2(front, back); }
			
		} while (v1 != 0);
	
	system("pause");
	return 0;
}
void sort(node *&front, node *&back){
		if (front != NULL){
			node*pv1 = front;
			while (pv1 != NULL){
				node *pv = front;
				while (pv->next != NULL){
					/*if (pv1->next->next== front){ break; }*/
					if (pv->next->item < pv->item){
						node *temp = new node;
						if (pv != front){
							pv->pred->next = temp;
						}
						temp->pred = pv->pred;
						temp->item = pv->next->item;
						pv->pred = temp;
						pv->next = pv->next->next;
						temp->next = pv;
						if (pv->next != NULL){
							pv->next->pred = pv;
						}
						if (temp->pred == NULL){
							front = temp;
						}
						pv1 = front;
					}
					else {

						pv = pv->next;
					}
				}
				back = pv;

				pv1 = pv1->next;

			}
			cout << "Sucsessfuly sorted!\n";
		}
		else { cout << "The list is empty!\n"; }
}
//void sort2(node *&front, node *&back){
//	bool t = 0, t2 = 0;
//	if (front != NULL){
//		node*pv1 = front;
//		while (pv1 != front ){
//			if (t2 == 1){ break; }
//			node *pv = front;
//			while (pv->next != front){
//				if (t == 1){ break; }
//				/*if (pv1->next->next== front){ break; }*/
//				if (pv->next->item < pv->item){
//					node *temp = new node;
//					if (pv != front){
//						pv->pred->next = temp;
//					}
//					temp->pred = pv->pred;
//					temp->item = pv->next->item;
//					pv->pred = temp;
//					pv->next = pv->next->next;
//					temp->next = pv;
//					if (pv->next != NULL){
//						pv->next->pred = pv;
//					}
//					if (temp->pred == NULL){
//
//						front = temp;
//					}
//					pv1 = front;
//				}
//				else {
//				if (pv->next == front){ t = 1; }
//					pv = pv->next;
//				}
//				
//			}
//			back = pv;
//
//			pv1 = pv1->next;
//			if (pv1 == front){ t2 = 1; }
//		}
//		cout << "Sucsessfuly sorted!\n";
//	}
//	else { cout << "The list is empty!\n"; }
//}
void sort2(node *&front, node *&back){
	if (front != NULL){
		
			node *pv = front;
			do{
				
				if (pv->next->item < pv->item){
					node *temp = new node;
					if (pv != front){
						pv->pred->next = temp;
					}
					temp->pred = pv->pred;
					temp->item = pv->next->item;
					pv->pred = temp;
					pv->next = pv->next->next;
					temp->next = pv;
					if (pv->next != NULL){
						pv->next->pred = pv;
					}
					if (temp->pred == NULL){
						front = temp;
					}
				
				}
				else {
					pv = pv->next;
				}
			}while (pv->next != front);
			back = pv;
			
		cout << "Sucsessfuly sorted!\n";
	}
	else { cout << "The list is empty!\n"; }
}

void circle(node *&front, node *&back){
	if (back->next == front){
		cout << "Alredy circled!\n";
		return;}
	back->next = front;
	front->pred = back;
	cout << "The list is circled\n";
	cout << "Front=" << front<<endl;
	cout << "Back next ="<<back->next<<endl;
	cout << "Back=" << back<<endl;
	cout << "Front pred=" <<front->pred<<endl;
}
void uncircle(node *&front, node *&back){
	if (back->next == NULL){
		cout << "Alredy uncircled!\n";
		return;
	}
	back->next = NULL;
	front->pred = NULL;
	cout << "The list is uncircled\n";
	cout << "Front=" << front << endl;
	cout << "Back next =" << back->next << endl;
	cout << "Back=" << back << endl;
	cout << "Front pred=" << front->pred << endl;
}
int get(){
	int k;
	do {
		cin.clear();
		cin.ignore(cin.rdbuf()->in_avail());
		cin >> k;
		if (cin.fail()){
			cout << "Wrong input,enter a digit" << endl;
		}
	} while (cin.fail());
	return k;
}
void add(node *&front,node *&back){
	int item;
	int v = -1;
	while (v != 0){
		node *pv = new node;
	cout << "\t1-Add to the front" << endl;
	cout << "\t2-Add to the back" << endl;
	cout << "\t3-Add by position" << endl;
	cout << "\t4-Add by value" << endl;
	cout << "\t0-back\n Action:";
		v = get();
		if (v > 4 || v < 0){ cout << "Choose from 0-4\n"; }
		if (v != 0){
			cout << "Enter  input x= ";
			item = get();
			pv->item = item;
			coun++;
		}
		
		if (v == 1){
			if (front == NULL){
				pv->next = NULL;
				front = pv;
				front->pred = NULL;
				back = front;
			}
			else{
				pv->next = front;
				front->pred = pv;
				front = pv;
				front->pred = NULL;
				
			}
		}else if (front == NULL && v!=0){
			cout << "List is empty, value will be first"<<endl;
			pv->next = NULL;
			front = pv;
			front->pred = NULL;
			back = front;
			continue;
		}
		if (v == 2){
			pv->pred = back;
			back->next = pv;
			pv->next = NULL;
			back = pv;
		}
		if (v == 3){
			int v1 = -1, k = 1; bool t = 0;
			cout << "Enter the position = " ;
			v1=get();
			node *pv1 = new node;
			pv1 = front;
			while (pv1 != NULL){
				if (v1 == 0){
					pv->pred = NULL;
					pv->next = front;
					front->pred = pv;
					front = pv;
					t = true;
					break;

				}
				if (k == v1 && k>0){
					pv->next=pv1->next;
					if (pv1->next != NULL){
					pv1->next->pred = pv;}
					pv->pred = pv1;
					pv1->next=pv;
					pv1 = pv;
					t = true;
				}
				back = pv1;
				pv1 = pv1->next;
				k++;
			}
			if (t == 0){
				cout<<v1<<" position is not found(\n";
				char g = 'o';
				cout << "Do you want to add to the end?(y/n)\n";

				while (g != 'Y' || g != 'y' || g != 'N' || g != 'n'){
					cin >> g;
					if (g == 'y' || g == 'Y'){
						pv->pred = back;
						back->next = pv;
						pv->next = NULL;
						back = pv;
						break;
					}
					else if (g == 'N' || g == 'n'){
						cout << "The element was not added" << endl;
						break;
					}
					else{
						cout << "Choose y/n?Please..\n";
					}}
				}
		}
		if (v == 4){
			int v1,v2;
			bool t = 0;
			cout << "\t\t**Adding by value**" << endl;
			cout << "Enter the value to search item= ";
			v2 = get();
				cout << "\t\t1-Add before this value" << endl;
				cout << "\t\t2-Replace the value" << endl;
				cout << "\t\t3-Add after this value" << endl;
				cout << "\t\tAction: " ;
				v1 = get();
				node *pv1 = new node;
				pv1 = front;
				while ( pv1->item != v2){
					pv1 = pv1->next;
					if (pv1 == NULL){ break; t = 0; }
				}
			if (pv1 != NULL){
				if (v1 == 1){
					if (front->item == v2){
						pv->pred = NULL;
						pv->next = front;
						front->pred = pv;
						front = pv;
						t = true;
					}
					else if (pv1->item == v2){
							pv->pred = pv1->pred;
							pv->next = pv1;
							pv1->pred->next = pv;
							pv1->pred = pv;
							pv1 = pv;
							t = 1;
					}	}
				if (v1 == 2){
					if (front->item == v2){
						pv->pred = NULL;
						front->pred = pv;
						pv->next = front->next;
						front->next->pred = pv;
						front = pv;
						t = 1;
					}
					else if(pv1->item==v2){
					pv->pred = pv1->pred;
					pv->next = pv1->next;
					pv1->pred->next = pv;
					
					if (pv1->next != NULL){
					pv1->next->pred = pv;
					}else back = pv;
					pv1 = pv;
					t = 1;
					}
				}
				if (v1 == 3){
					if (front->item == v2){
						pv->next = front->next;
						front->next->pred = pv;
						pv->pred = front;
						front->next= pv;
						t = 1;
					}
					else if(pv1->item==v2){
						pv->next = pv1->next;
						if (pv1->next != NULL){
							pv1->next->pred = pv;
						}
						else back = pv;
						pv->pred = pv1;
						pv1->next = pv;
						t = 1;
					}
				}}

				if (t != 1){
					cout << "The value is not found" << endl;	}
		}}
}
void print(node *&front, node *&back)
{
	int v1;
	cout << "\t\t1- Front to Back " << endl;
	cout << "\t\t2-Back to Front" << endl;
	cout << "\t\tAction: ";
	v1 = get();
	if (v1 == 1){
	if (front != NULL){
		cout << "Our list: ";
		node* pv = front;
		while (pv!= NULL)
		{
			cout << pv->item << " ";
			
			
			if (pv->next == front){ break; }
			pv = pv->next;
		}
	}
	else
		cout << "List empty";}
	if (v1 == 2){
		if (front != NULL){
			cout << "Our list: ";
			node* pv = back;
			while (pv != NULL)
			{
				cout << pv->item << " ";
				pv = pv->pred;
			}
		}
		else
			cout << "List empty";
	}
	cout << endl;
}

void delet(node *&front, node *&back){
	int v = -1,p,k=1;
	bool t = 0;
		cout << "\t1-Delete from the front" << endl;
		cout << "\t2-Delete from the back" << endl;
		cout << "\t3-Delete by position" << endl;
		cout << "\t4-Delete by value" << endl;
		cout << "\t0-back\n Action:";
		v = get();
		node *pv = new node;
		if (front != NULL){
			if (v == 1){
				pv = front;
				cout << front->item << " is deleted" << endl;
				front->next->pred = NULL;
				front = front->next;
				delete pv;
				coun--;
			}
			if (v == 2){
				if ( front!= NULL){
					pv = back;
					back = back->pred;
					cout << pv->item << " is deleted" << endl;
					back->next = NULL;
					delete pv;
					coun--;
			}}
			if (v == 3){
				cout << "Enter the position p=";
				p = get(); k = 1;
				if (p == 0){
					pv = front;
					cout << front->item << " is deleted" << endl;
					if (front->next != NULL){
					front->next->pred = NULL;
					}
					front = front->next;
					delete pv;
					t = 1;
					coun--;
				}
				else{
				node *pv1 = front->next;
				while (pv1!=NULL)
				{if (k == p){t = 1;
				pv = pv1;
				if (pv1 -> next != NULL){
				pv1->next->pred = pv1->pred;
				}
				else back = pv1->pred;
				pv1->pred->next = pv1->next;
				cout << pv->item << " is deleted" << endl;
				pv1 = pv1-> pred;
				delete pv;
				t = 1;
				}
				pv1 = pv1->next;
				k++;
				coun--;
				}}
				if (t == 0){
					cout << p << "th position is not found\n";
				}
			}
			if (v == 4){
				cout << "Enter the value to search v=";
				p = get();
				node *pv1 = new node;
				pv1 = front;
					int i = 0;
					while ( pv1 != NULL){
						if (p == front->item){
					pv = front;
					front = front->next;
					if (front != NULL){ front->pred = NULL; }
					cout << pv->item << " is deleted index= " << i<< endl;
					delete pv;
					t = 1;
					coun--;
					pv1 = front;
					i++;
					if (pv1 == NULL ){ front = NULL; coun = 0; }
					continue;

				}else if (pv1->item == p){
					t = 1;
				pv = pv1;
				pv1->pred->next = pv1->next;
				if (pv1->next != NULL){
				pv1->next->pred = pv1->pred;}
				else back = pv1->pred;
				pv1 = pv->next;
				cout << pv->item << " is deleted index= "<< i<<"\n";
				delete pv;
				coun--;
				}i++;
				if (pv1== NULL){ break; }
					pv1 = pv1->next;
				
				}
				if (t == 0){
					cout << p << " the element is not found(\n";
			}
			
			}
		}else{ cout << "List is empty\n"; }
}
void clear(node *&front){
	node *pv = front;
		while (pv!= NULL)
		{
			node *pv1 = pv;
			front = pv->next;
if (pv != NULL){
if (pv->next == front){ break; }
pv = pv->next;
}
cout << "Deleted" << pv1->item << endl;
			delete pv1;
			
		}
	front = NULL;
	
}
void count(node*&front){
	int k = 0;
	node *pv = front;
	while (pv != NULL){
		pv = pv->next;
		k++;
		if (pv == front){ break; }
	}
	cout << "The queue has " << k << " element(s)" << endl;
}
void searchp(int i, node *&front){
	int k = 0;
	bool t = 0;
	node*pv = new node;
	pv = front;
	while (pv != NULL){
		if (k == i){
			cout << "The element is found) value is " << pv->item << endl;
			t = 1;
			break;
		}pv = pv->next;
		k++; if(pv!=NULL){
		//if (pv->next == front){ break; }

	}}
	if (t == false){
		cout << "Not found(" << endl;
	}
}
void searchv(int i, node *&front ){
	int k = 0;
	bool t = 0;
	node *pv = new node;
	pv = front;
	while (pv != NULL){
		if (pv->item == i){
			cout << "The element is found) index is " << k << endl;
			t = 1;
		}pv = pv->next;
		k++;
		if (pv != NULL){
		if (pv->next == front){ break; }}
	}
	if (t == false){
		cout << "Not found(" << endl;
	}
}