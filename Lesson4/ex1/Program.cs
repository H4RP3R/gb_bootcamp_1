/*
for (int n = 0; n < 90; n++)
{
    int count = 0;
    int i = n;
    while (i > 0)
    {
        count++;
        s += i;
        i /= 2; // log(n)+1
    }
    Console.WriteLine($"n:{n} count:{count}");
}
*/

int n = Random.Shared.Next(10000000);
double s = 0;
int i = n;

for (int j = 2; j < n / 2; j++)
{
    while (i > 0)
    {
        s += i;
        i /= 2;
    }
}

// (n/2-2) * (log(n)+1) => O(n log(n))