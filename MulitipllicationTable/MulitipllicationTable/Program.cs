// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");

for (int i = 1; i <= 9; i++)
{
    Console.Write(i);

    for (int j = 1; j <= 9; j++)
    {
        Console.Write("\t{0}", i * j);
    }
    Console.WriteLine();

}

Console.ReadLine();