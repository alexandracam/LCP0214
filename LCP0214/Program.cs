// MIS 3013 001
// Feb 14, 2024
// Alexandra Camarena
// 113568154

Console.WriteLine("% ");
// between 10 and 200, 3 & 5
// 10 15 

int N;
N = 0;

for (int i = 10; i <= 200; i = i + 1)
{
    if (i % 3 ==0 && i%5==0)
    {
        N = N + 1;
        Console.WriteLine(i);
    }
}

Console.WriteLine(N);