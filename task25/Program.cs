int RaiseToPower(int arg1, int arg2)
{
    int number = arg1;
    for (int i = 2; i <= arg2; i++)
    {
        number =  number * arg1; 
    }
    return number;
}

Console.WriteLine("This program assepts two numbers and raise first number to a power of the second. ");

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

 int result = RaiseToPower(num1, num2);
 Console.WriteLine(result);