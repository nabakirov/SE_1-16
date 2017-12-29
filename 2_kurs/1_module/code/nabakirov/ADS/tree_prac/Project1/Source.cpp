#include <iostream>
using namespace std;


struct Tree {
	int element;
	Tree *left;
	Tree *right;
	Tree *parent;
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

Tree *insert(Tree *&root, int element, Tree *parent = NULL) {
	if (root == NULL) {
		root = new Tree;
		root->element = element;
		root->left = NULL;
		root->right = NULL;
		root->parent = parent;
		cout << "inserted element:\t" << element << endl;
	}
	else {
		if (element > root->element) {
			insert(root->right, element, root);
		}
		else {
			insert(root->left, element, root);
		}
	}
	return root;
}

int count(Tree *& root) {
	if (root == NULL) {
		return NULL;
	}
	else {
		int cnt = 1;
		cnt += count(root->left);
		cnt += count(root->right);
		return cnt;
	}
}

void print(Tree *&root, int level = 0) {
	if (root == NULL) {
		return;
	}
	print(root->right, level + 1);
	for (int i = 0; i < level; i++) {
		cout << "       ";
	}
	cout << root->element << endl;
	print(root->left, level + 1);
}

int height(Tree *&root) {
	if (root == NULL) {
		return 0;
	}
	else {
		if (root->left == NULL && root->right == NULL) {
			return 0;
		}
		else {
			if (height(root->left) > height(root->right)) {
				return height(root->left) + 1;
			}
			else {
				return height(root->right) + 1;
			}
		}
	}
}

int del(Tree *&root) {
	if (root == NULL) {
		return NULL;
	}
	Tree *right = new Tree;
	Tree *left = new Tree;
	if (root->right != NULL) {
		Tree *temp = root->right;
		while (temp->left != NULL) {
			temp = temp->left;
		}
		right = temp;
		cout << "right = " << right->element << endl;
	}
	if (root->left != NULL) {
		Tree *temp = root->left;
		while (temp->right != NULL) {
			temp = temp->right;
		}
		left = temp;
		cout << "left = " << left->element << endl;
	}
	
	return 0;
}

Tree* find(Tree*& root, int item) {
	if (root == NULL) {
		
		return NULL;
	}
	else {
		if (item == root->element) {
			//cout << root->element << "  ";
			return root;
		}
		else {
			if (item < root->element) {
				return find(root->left, item);
				//cout << root->element << "  ";
			}
			else {
				return find(root->right, item);
				//cout << root->element << "  ";
			}
		}
	}
}

void insert(Tree *& root) {
	int action;
	do {
		cout << "enter 999 to exit" << endl;
		cout << "enter element: ";
		cin >> action;
		if (action == 999) {
			break;
		}

		Tree *temp = insert(root, action);

		cout << "count of elements:\t" << count(root) << endl;
		cout << "height of the tree:\t" << height(root) << endl;
		print(root, 0);
		del(root);


	} while (action != 999);
}

void deleteTree(Tree *& root) {
	if (root != NULL) {
		deleteTree(root->left);
		deleteTree(root->right);
		delete root;
		root = NULL;
	}
	else {
		cout << "tree is empty\n";
	}
}

int delete_el(Tree*&root, int element) {
	if (root == NULL) {
		cout << "Tree is empty";
		return NULL;
	}
	Tree* found = find(root, element);
	if (found == NULL) {
		return NULL;
	}
	
	Tree* deleted = found;
	int todel;
	
		Tree* replace = found;
		bool changed = false;
		if (found->right != NULL) {
			replace = found->right;
			while (replace->left != NULL) {
				replace = replace->left;
				changed = true;
			}
			if (changed) {
				replace->parent->left = replace->right;
				if (found->parent != NULL) {
					found->parent->right = replace;
				}
			}			
		}
		if (found->left != NULL && !changed) {
			replace = found->left;
			while (replace->right != NULL) {
				replace = replace->right;
				changed = true;
			}
			if (changed) {
				replace->parent->right = replace->left;
				if (found->parent != NULL) {
					found->parent->left = replace;
				}
			}	
		}
		if(!changed) {
			if (found->right != NULL) {
				replace = found->right;
				
				replace->left = found->left;
				replace->parent = found->parent;
				if (found->left != NULL) {
					found->left->parent = replace;
					
				}
				if (found->parent != NULL) {
					if (found->parent->left == found) {
						found->parent->left = replace;
					}
					else {
						found->parent->right = replace;
					}

				}
				found = replace;

			}
			else if (found->left != NULL) {
				replace = found->left;
				replace->right = found->right;
				replace->parent = found->parent;
				if (found->parent != NULL) {
					if (found->parent->left == found) {
						found->parent->left = replace;
					}
					else {
						found->parent->right = replace;
					}
					
				}
				found = replace;
			}
			else {
				if (found->parent != NULL) {
					if (found->parent->left == found) {
						found->parent->left = NULL;
					}
					else {
						found->parent->right = NULL;
					}

				}
				else {
					todel = deleted->element;
					delete deleted;
					root = NULL;
					return todel;
				}
				
			}
			
			todel = deleted->element;
			
			while (found->parent != NULL) {
				found = found->parent;
			}
			root = found;
			delete deleted;
			return todel;
		}
		
		replace->left = found->left;
		replace->right = found->right;
		replace->parent = found->parent;
		if (found->left != NULL) {
			found->left->parent = replace;
		}
		if (found->right != NULL) {
			found->right->parent = replace;
		}
		found = replace;

		todel = deleted->element;
		delete deleted;
		
	
		while (found->parent != NULL) {
			found = found->parent;
		}
		root = found;
		return todel;
}


int main() {
	Tree *root = NULL;
	Tree *parent, *l, *r;
	int action = 0;
	while (action != 999) {
		cout << "1 - insert" << endl;
		cout << "2 - print" << endl;
		cout << "3 - destroy tree" << endl;
		cout << "4 - find" << endl;
		cout << "5 - delete node" << endl;
		cin >> action;
		int p, t;
		Tree* temp;
		switch (action)
		{
		case 1: 
			insert(root); 
			break;
		case 2: 
			print(root); 
			break;
		case 3:
			deleteTree(root);
			break;
		case 4:
			
			cout << "to find - ";
			cin >> p;

			temp =find(root, p);
			if (temp == NULL) {
				cout << "not found\n";
				break;
			}
			
			cout << "found node - " <<  temp->element << endl;
			cout << "parents - ";
			parent = temp;
			l = temp; 
			r = temp;
			while (parent->parent != NULL) {
				parent = parent->parent;
				cout << parent->element << " ";
				
			}
			cout << "\nleft children - ";
			if (l->left != NULL) {
				l = l->left;
				cout << l->element << " ";
				
			}
			cout << "\nright children - ";
			if (r->right != NULL) {
				r = r->right;
				cout << r->element << " ";
				
			}
			cout << endl;

			break;
		case 5:
			
			cout << "enter element - ";
			cin >> p;
			t = delete_el(root, p);
			if (t == NULL) {
				cout << "element not found" << endl;
				break;
			}
			cout << "deleted element " << t << endl;
		default:
			break;
		}
	}
}