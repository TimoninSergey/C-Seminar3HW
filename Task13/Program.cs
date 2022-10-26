Console.WriteLine("Введите число");
string Number = Console.ReadLine();

int[] NumMassive = new int[Number.Length];
int count = 0;

if (Number.Length < 3)
{
    Console.WriteLine("Третьего числа нет");
}

else
{
    while (count < Number.Length)
    {
        NumMassive[count] = int.Parse(Number[count].ToString());
        count++;
    }
int Answer = NumMassive[2];
Console.WriteLine("Третье число равно");
Console.WriteLine(Answer);
}

// Примечание: задача решена до просмотра семинара, использован способ решения из внешнего источника