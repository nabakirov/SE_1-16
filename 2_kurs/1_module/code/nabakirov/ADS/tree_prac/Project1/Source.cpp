#include <iostream>
using namespace std;


struct Tree {
	int element;
	Tree *left;
	Tree *right;
};

Tree *insert(Tree *&root, int element) {
	if (root == NULL) {
		root = new Tree;
		root->element = element;
		root->left = NULL;
		root->right = NULL;
		cout << "inserted element:\t" << element << endl;
	}
	else {
		if (element > root->element) {
			insert(root->right, element);
		}
		else {
			insert(root->left, element);
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

void find(Tree*& root, int item) {
	if (root == NULL) {
		cout << "not found";
	}
	else {
		if (item == root->element) {
			cout << root->element << "  ";
		}
		else {
			if (item < root->element) {
				find(root->left, item);
				cout << root->element << "  ";
			}
			else {
				find(root->right, item);
				cout << root->element << "  ";
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
}


int main() {
	Tree *root = NULL;
	int action = 0;
	while (action != 999) {
		cout << "1 - insert" << endl;
		cout << "2 - print" << endl;
		cout << "3 - delete" << endl;
		cout << "4 - find" << endl;
		cin >> action;
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
			int p;
			cout << "to find - ";
			cin >> p;

			find(root, p);
			cout << endl;
			break;
		default:
			break;
		}
	}
}