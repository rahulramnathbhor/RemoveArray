using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveArray
{
    internal class Program
    {
      
        public class Example
        {
            public static void Main()
            {
                int[] array = { 1, 3, 4, 5, 4, 2,1 };
                int item = 2 ;

                List<int> nums = new List<int>(array);
                nums.RemoveAt(nums.IndexOf(item));
                array = nums.ToArray();

                Console.WriteLine(String.Join(",", array));
            }
        
        }
    }
}
