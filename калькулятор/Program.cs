Console.WriteLine("Введите 1 число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Что бы произвести сложение введите 0; вычитание 1; умножение 2; деление 3");
double g = Convert.ToInt32(Console.ReadLine());
double d = a + b;
double f = a - b;
double e = a * b;
double j = a / b;


if (g == 0)
{
    Console.Write("= ");
    Console.WriteLine(d);
}    
    
if (g == 1)
{   
    Console.Write("= ");
    Console.WriteLine(f);
}   

if (g == 2)
{  
    Console.Write("= ");
    Console.WriteLine(e);
}  

if (g == 3)
{  
    Console.Write("= ");
    Console.WriteLine(j);
}  
