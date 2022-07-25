// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int temp = numM;

if (numM > numN) 
{
  numM = numN; 
  numN = temp;
}

void SumNaturalNum(int numM, int numN, int sum)
{
  sum = sum + numN;
  if (numN <= numM)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  SumNaturalNum(numM, numN - 1, sum);
}

SumNaturalNum(numM, numN, temp=0);
