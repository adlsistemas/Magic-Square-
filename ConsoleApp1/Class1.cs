using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Class1
    {

        internal static void SolutionMagicSquare(int valueN)
        {
            if (valueN < 0)
                return;

            int[,] square = new int[valueN, valueN];
            int quotient = Math.DivRem(valueN, 2, out int remainder);
            int valueX = (remainder == 0 ? quotient : quotient + 1) - 1;
            int valueY = 0;
            int value = 1;

            square[valueY, valueX] = value;
            for (int y = 0; y < valueN * valueN; y++)
            {
                valueY--;
                valueX++;
                value++;
                if (value > valueN * valueN)
                    break;
                do
                {
                    var canDrawY = validatePosY(valueY);
                    var canDrawX = validatePosX(valueX, valueN);
                    if (canDrawY && canDrawX)
                    {
                        if (square[valueY, valueX] == 0)
                        {
                            square[valueY, valueX] = value;
                            break;
                        }
                        else
                        {
                            valueY++;
                        }
                    }
                    if (!canDrawY)
                        if (valueY < 0)
                            valueY = valueN - 1;
                    if (!canDrawX)
                        if (valueX > valueN - 1)
                            valueX = 0;
                } while (true);
            }
            for (int i = 0; i < valueN; i++)
            {
                for (int j = 0; j < valueN; j++)
                {

                    Console.Write(square[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool validatePosY(int value)
        {
            if (value < 0)
                return false;
            else
                return true;
        }
        private static bool validatePosX(int value, int maxValue)
        {
            if (value + 1 > maxValue)
                return false;
            else
                return true;
        }

    }
}
