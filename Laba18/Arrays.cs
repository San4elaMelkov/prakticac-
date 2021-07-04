using System;

namespace Laba18
{
    public class Arrays
    {
        public static int[] Sort(int[] arr, bool orderBy)
        {
            Array.Sort<int>(arr);
            if (!orderBy)
            {
                Array.Reverse(arr);
            }
            return arr;
        } 
    }
}
