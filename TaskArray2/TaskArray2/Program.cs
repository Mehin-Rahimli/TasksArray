// Verilmis arraylerde eyni olan elementleri ekrana cap edin.
int[] nums1 = { 1, 3, 4, 2 };
int[] nums2 = { 2,3,5 };
bool maindublicate = false;
for (int i = 0; i < nums1.Length; i++)
{
    bool dublicate = false;

    for (int j = 0; j < nums2.Length; j++)
    {

        if (nums1[i] == nums2[j])
        {
            dublicate = true;
            break;
        }
    }
    if (dublicate)
    {
        maindublicate = true;
        Console.WriteLine(nums1[i]);
    }

}

if (!maindublicate)
{
    Console.WriteLine("There are no dublicate numbers");
}

//Alternative and easy way:
//int[] nums1 = {1,2,3,4,5};
//int[] nums2 = { 2, 3, 4 };
//for(int i= 0;i < nums1.Length; i++)
//{
//    bool dublicate=false;
//    for (int j = 0; j < nums2.Length; j++)
//    {
//        if (nums1[i] == nums2[j])
//        {
//            dublicate = true;
//            break;
//        }
//    }
//    if (dublicate)
//    {
//        Console.WriteLine(nums1[i]);
//    }
//}
