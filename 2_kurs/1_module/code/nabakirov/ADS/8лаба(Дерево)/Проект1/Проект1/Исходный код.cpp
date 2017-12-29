#include<iostream>
using namespace std;
struct tree{
	int item;
	tree *left;
	tree *right;
};
bool t = 0;
tree *minimum(tree* node);
tree* deletebk(tree* root, int key);
bool find(tree *&root, int val ,bool t);
tree *insert(tree *&root, int item);
tree *delet(tree *&root);
void print(tree *root,int level);
int count(tree *root);
int hight(tree *root);
int level(tree *root);
tree *destroy(tree *&root);
void preorder(tree *root);
void inorder(tree *root);
void postorder(tree *root);
int get();
int main(){
	tree *root= new tree;
	root = NULL;
	int v=-1,level1=0;
	while (v!=0){
	cout << "\tAction\n";
	cout << "1-insert\n";
	cout << "2-print\n";
	cout << "3-count\n";
	cout << "4-hight\n";
	cout << "5-level\n";
	cout << "6-Delete leaf\n";
	cout << "7-Traversal\n";
	cout << "8-Destroing\n";
	cout << "9-Search\n";
	cout << "10-Delete by key\n";
	cout << "\tAction:";
	v = get();
	
		if (v == 1){
			//for (int i = 0; i < 5; i++){}
			cout << "Enter item=";
			int item = get();
			insert(root,item);
			//cout << "Our tree:\n";
			cout << endl;
			print(root, level1);
		}
		if (root == NULL){ cout << "Tree is empty insert first!\n"; continue; }
		if (v == 2){
			cout << "Our tree:\n";
			print(root,level1);
		}
		if (v == 3){
			cout << "Quntity:";
			cout << count(root) << endl;
		}
		if (v == 4){
			cout << "Hight:";
			cout << hight(root) << endl;
		}
		if (v == 5){
			cout << "Level:";
			cout << level(root) << endl;
		}
		if (v == 6){
			bool t = 0;
			cout << "Removing leaves...\n";
			delet(root) ;
		}
		if (v == 7){ int k; 
		cout << "\tPlease choose!\n";
		cout << "\t1-Preorder\n";
		cout << "\t2-Inorder\n";
		cout << "\t3-Postorder\n";
		k = get();
			if (k == 1){ cout << "Pre: "; preorder(root); cout << endl; }
			if (k == 2){ cout << "In:"; inorder(root); cout << endl; }
			if (k == 3){ cout << "Post:"; postorder(root); cout << endl; }}
		if (v == 8){ destroy(root);}
		if (v == 9){ cout << "Value to search: "; 
		int val = get(); 
		t=find(root, val, t);
		if (t==1){
			cout << " found!)\n";
		}
		else { cout << "Not found!(\n"; }
		}
		if (v == 10){
			cout << "Value to search: ";
			int key = get();
			deletebk(root,key);
		}

}
system("pause");
return 0;
}
tree *minimum(tree* node)
{
	struct tree* pv = node;

	while (pv->left != NULL)
		pv = pv->left;

	return pv;
}
tree* deletebk(tree* root, int key){
	if (root == NULL) return root;

	if (key < root->item){
		root->left = deletebk(root->left, key);}

	else if (key > root->item){
		root->right = deletebk(root->right, key);}

	else
	{
		if (root->left == NULL)
		{
			tree *temp = root->right;
			delete root;
			return temp;
		}
		else if (root->right == NULL)
		{
			tree *temp = root->left;
			delete root;
			return temp;
			
		}
		tree *temp = minimum(root->right);
		
		root->item = temp->item;
		root->right = deletebk(root->right, temp->item);
	}
	return root;
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
tree *insert(tree *&root, int item){
	if (root == NULL){
		root = new tree;
		root->item = item;
		root->left = NULL;
		root->right = NULL;
	}else{
		if (item > root->item){
			insert(root->right, item);
		}
		else if (item == root->item){ cout << "Element already exists\n"; }
		else{
			insert(root->left, item);
		}
	}
	return root;
}
tree  *delet(tree *&root){
	if (root != NULL)
	{
		if (root->left == NULL && root->right == NULL)
		{
			cout <<root->item<<" is deleted\n";
			delete root;
			root = NULL;
			return NULL;
		}
		else
		{
			root->left = delet(root->left);
			root->right = delet(root->right);
		}
	}
	return root;
}
bool find(tree *&root,int val,bool t){
	if (root != NULL){
	if (val == root->item){
		t = 1;
		if (t == 1){ cout << root->item << "--"; }
		return t;
	}
	else if (val < root->item){
		t=find(root->left, val,t);

		if (t == 1){ cout << root->item << "--"; }
		return t;}
	else{
		t=find(root->right, val,t);
		if (t == 1){ cout << root->item << "--"; }
		return t;
	}}
}
tree *destroy(tree *&root){
	if (root != NULL){	
		while (root != NULL){
			destroy(root->left);
			destroy(root->right);
			delete root;
			root = NULL;
		}
	}
	return root;
}
void preorder(tree *root){
	if (root == NULL){
		return;
	}
	cout << root->item << " ";
	preorder(root->left);
	preorder(root->right);
}
void inorder(tree *root){
	if (root == NULL){
		return;
	}
	inorder(root->left);
	cout << root->item<<" ";
	inorder(root->right);
}
void postorder(tree *root){
	if (root == NULL){
		return;
	}
	inorder(root->left);
	inorder(root->right);
	cout << root->item << " ";
}	
void print(tree *root, int level){
	if (root != NULL){
		
		print(root->right, level + 1);
		for (int i = 0; i < level; i++){
			cout << "~";
		}
		cout << root->item << endl;
		print(root->left, level + 1);
	}
}
int count(tree *root){
	if (root != NULL){
		int cnt = 1;
		cnt += count(root->left);
		cnt += count(root->right);
		return cnt;
	}
	else{
		return NULL;
	}
}
int hight(tree *root){
	if (root != NULL){
		if (root->left == NULL && root->right == NULL){
			return 0;
		}
		else{
			if (hight(root->left) > hight(root->right)){
				return hight(root->left) + 1;
			}
			else {
				return hight(root->right) + 1;
			}
		}
	}
	else{
		return 0;
	}
	cout << endl;
}
int level(tree *root){
	if (root != NULL){
		if (root->left == NULL && root->right == NULL){
			return 0;
		}
		else{
			if (level(root->left) > level(root->right)){
				return level(root->left) + 1;
			}
			else {
				return level(root->right) + 1;
			}
		}
	}
	else{
		return 0;
	}
	cout << endl;
}
