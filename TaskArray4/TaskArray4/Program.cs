//Verilmis ededin mertebeleri cemini tapin.
Console.WriteLine("enter the number:");
int number =Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number != 0)
{
    int num=number % 10;
    sum += num;
    number= number / 10;
}
Console.WriteLine("Mertebelerin cemi: " +sum);