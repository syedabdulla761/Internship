using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class trialClass
    {
        int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Dictionary<int, int> map = new Dictionary<int, int>();
        int target = 21;
        public void write()
        { 
            for(int i=0;i<nums.Length;i++){
                map[nums[i]]=i;
            }

            Console.WriteLine(map.ContainsKey(target - nums[0]));
        }
    }
}
