LINKED LIST:

1. INSERTING NODE AT THE BEGINING.

using namespace std;

struct Node {
	int data;
	Node* link;
};

Node* head;

void Insert(int x) {
	Node* temp = (Node*)malloc(sizeof(Node));
	temp->data = x;
	temp->link = head;
	head = temp;
}

void Print() {
	Node* temp = head;
	printf("List is : ");
	while (temp != NULL) {
		printf(" %d ", temp->data);
		temp = temp->link;
	}
	printf("\n");
}

int main() {
	head = NULL;
	int n, i, x;
	printf("Enter how many numbers : \n");
	scanf_s("%d", &n);
	for (i = 0; i < n; i++) {
		printf("Enter the number : \n");
		scanf_s("%d", &x);
		Insert(x);
		Print();
	}
	getchar();
}