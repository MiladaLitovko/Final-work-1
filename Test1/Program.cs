Console.WriteLine("Введите длину массива");
int number = Convert.ToInt32(Console.ReadLine());
string[] arrayOfString = new string[number]; 

for(int i = 0; i < number; i++)
{
    Console.WriteLine($"Введите строку номер {i+1}");
    string currentString = Console.ReadLine();
    arrayOfString[i] = currentString;
}
Console.Write("Массив равен: ");
Console.WriteLine(string.Join(",",arrayOfString));


int countOfLength = 0;

for(int i = 0; i < number; i++)
{
    if(arrayOfString[i].Length <= 3)
    {
        countOfLength++;
    }
}

string[] newArrayOfString = new string[countOfLength];
int count = 0;
for(int i = 0; i < number; i++)
{
    if(arrayOfString[i].Length <= 3)
    {
        newArrayOfString[count] = arrayOfString[i];
        count++;
    }
}
Console.Write("Новый массив равен: ");
Console.WriteLine(string.Join(",",newArrayOfString));