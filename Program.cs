string[]inputArray = { "hello", "bay", "good", "1",};
int arraySize = 0;
int arrayInd = 0;


for (int i = 0; i < inputArray.Length; i++)
{
    if(inputArray[i].Length <= 3) arraySize++;
}
string[]Array = new string[arraySize];

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    Array[arrayInd++] = inputArray[i];
}

Console.Write("Результат: ");
for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + ((i !=Array.Length-1) ? ", " : ""));