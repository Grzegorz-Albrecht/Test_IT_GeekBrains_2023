//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
string[] a=new string[] {"1234","1567","-2","computer scince"};
string[] b=new string[a.Length];
Array.Copy(a,b,a.Length);
Console.WriteLine("Массив a: ");
PrintArray(a);
Console.WriteLine();
Console.WriteLine("Массив b(копия a): ");
PrintArray(b);
Console.WriteLine();
System.Console.WriteLine("Измененный массив a: ");
ChangeArray (a);

void ChangeArray(string[] a)
{   int i=0;
    foreach (var value in a )
    {
     if (value.Length <= 3)
        System.Console.Write($"{a[i]} ");
        i++;
    }
}

void PrintArray(string[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
}