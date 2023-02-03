// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 5;

void N1numbers(int n)
{
    Console.WriteLine(n);
    if(n==1)return;
    N1numbers(n-1);
    
}

N1numbers(number);