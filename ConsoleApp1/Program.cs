// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
int value = 0;
do
{
    Console.WriteLine("Ingrese un numero mayor a 0");
    int.TryParse(Console.ReadLine(), out value);
} while (value == 0);

Class1.SolutionMagicSquare(value);


