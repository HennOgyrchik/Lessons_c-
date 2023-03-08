void FillArray(int[] collection){
    int length=collection.Length;
    int i=0;
     while (i<length){
        collection[i]=new Random().Next(1,10);
        i++;
     }
}


void PrintArray(int [] col){

    int count=col.Length;
    int position=0;

    while (position<count){
        Console.Write(col[position]+" ");
        position++;
    }
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int i=0;
    int position=-1;

    while (i<count){
        if (collection[i]==find){
            position=i;
            break;
        }
        i++;
    }
    return position;
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int pos= IndexOf(arr,4);
Console.WriteLine(pos);