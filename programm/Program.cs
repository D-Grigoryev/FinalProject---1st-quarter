
string[] arrayStart = new string[] { "hello", "2", "world", ":-)"};


string [] checkArrayElement (string [] arrStart)
{
    int j = 0;
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrStart[i].Length <= 3){
        j++;
    }
}
string[] arrayFinal = new string[j];

for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrStart[i].Length <= 3){
    arrayFinal [count] = arrStart[i];
    count++;
}

}return arrayFinal;
}

void printArray (string [] arr){
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
}

printArray(checkArrayElement(arrayStart));



