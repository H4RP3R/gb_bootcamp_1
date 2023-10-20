using System.Diagnostics;

int[] array = 500_000.Create()
                .Fill();

// array.ConvertToStringAndPrintToTerminal();

int m = 100_000;
Stopwatch sw = new();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum {max} => {sw.ElapsedMilliseconds}");
