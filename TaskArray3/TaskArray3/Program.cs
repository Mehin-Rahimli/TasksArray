//Verilmis arrayin en kicik ve en boyuk elementlerinin indexlerini tapin
int[] array = { 90, 200, 3, 0, 5 };
int min = array[0];
int minindex = 0;
int max =array[0];
int maxindex = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i]; 
        minindex = i;
    }
   
    if (array[i] > max)
    { 
        max = array[i];
        maxindex = i;
    }
   
}
 Console.WriteLine("Minimum ededin indexi: "+minindex);
 Console.WriteLine("Maximum ededin indexi: "+maxindex);