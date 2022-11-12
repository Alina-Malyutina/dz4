int SumNumbers(int arg1)
{
    arg1 = Math.Abs(arg1);
    string strArg1 = arg1.ToString();
    int sum = 0;
    for(int i=0; i<strArg1.Length; i++)
    {
        int num = Convert.ToInt32(strArg1[i].ToString());
        sum = sum + num;
    }
    return sum;
}

Console.WriteLine("This program show sum of digits in your number");

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int summ = SumNumbers(number);
Console.WriteLine(summ);
