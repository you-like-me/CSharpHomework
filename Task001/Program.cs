Console.WriteLine("Введите целое число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine(max);