int[] arr = { 1, 2, 3, 4, 5, 6,4, 7, 8 };

int n=arr.Length;

int find =4;
int i=0;
while (i<n){

    if (arr[i]==find){
        Console.WriteLine(i);
        break;
    }
    i++;
}