// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int funcionAkkerman = Ack(numM, numN);

int Ack(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  else if (numN == 0) return Ack(numM - 1, 1);
  else return Ack(numM - 1, Ack(numM, numN - 1));
}

Console.Write($"A(M,N) = {funcionAkkerman} ");