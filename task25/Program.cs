// No25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//

Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int PowAtoB(int a, int b)
{
    int res=1;
    for (int i = 0; i < b; i++)
    {
        res=res*a;
    }

    return res;
}

double PowAtoBlog(int a, int b)
{
    double res=Math.Pow(a,b);
    
    return res;
}

void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}


int a=ReadData("Введите число а: ");
int b=ReadData("Введите число b: ");

DateTime d1 = DateTime.Now;
int res=PowAtoB(a,b);
PrintData(a+ " в степени "+ b +" = ", res);
Console.Write(DateTime.Now-d1);System.Console.WriteLine("- метод simple");
System.Console.WriteLine();
DateTime d2 = DateTime.Now;
double res1=PowAtoBlog(a,b);
PrintData(a+ " в степени "+ b +" = ", res1);
Console.Write(DateTime.Now-d2);System.Console.WriteLine("- метод log");