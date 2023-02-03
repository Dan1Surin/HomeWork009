
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

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