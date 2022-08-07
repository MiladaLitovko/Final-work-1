Console.WriteLine("Введите длину массива");
int number = Convert.ToInt32(Console.ReadLine());
string[] arrayOfString = new string[number]; 

for(int i = 0; i < number; i++)
{
    Console.WriteLine($"Введите строку номер {i+1}");
    string currentString = Console.ReadLine();
    arrayOfString[i] = currentString;
}
Console.WriteLine(string.Join(",",arrayOfString));

string[] newArrayOfString = new string[number];
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