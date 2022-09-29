//No27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
//числе.

Console.Clear();

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int value)
{
    System.Console.WriteLine(msg + value);
}


int SumDigitNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int SumDigitString(int num)
{
    string arr = num.ToString();
    char[]array = arr.ToCharArray();
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        sum = sum +(int)Char.GetNumericValue(array[i]);
        
    }
        return (sum);

}

int num = ReadData("Введите число = ");
DateTime d1 = DateTime.Now;
PrintData("Сумма цифр в числе " + num + " (SumDigitNum) равна = ", SumDigitNum(num));
Console.WriteLine(DateTime.Now-d1);
PrintData("Сумма цифр в числе " + num + " (SumDigitString) равна = ", SumDigitString(num));
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now-d2);