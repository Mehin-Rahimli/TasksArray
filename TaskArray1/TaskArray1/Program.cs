//Verilmis arrayde murekkeb ededleri ekrana cixarin.
int[] nums = { 1, 2, 3, 8, 5, 6, 7 };


for (int i = 0; i < nums.Length; i++)
{
    bool composite=false;
    if (nums[i] > 1)
    {
        for (int j = 2; i < nums[i]; i++)
        {
            if (nums[j] % i == 0)
            {
                composite = true;
                break;
            }
        }
    }
    if (composite)
    {
        Console.WriteLine(nums[i]);
    }

}




