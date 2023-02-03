// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
//  промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int M = 5;
int N = 100;
int SUM=0;


void N1numbers(int m, int n,int sum)
{
    sum=sum+m;
    if(m==n)  {Console.WriteLine(sum); return;}
    N1numbers(m+1,n,sum);
}

N1numbers(M,N,SUM);