using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组中的最大值，最小值，总和，平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] res = GetVs(nums);
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            Test(nums, out max, out min, out sum, out avg);
        }

        /// <summary>
        /// 计算一个数组的最大值，最小值，总和，平均数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetVs(int[] nums)
        {
            int[] res = new int[4];
            res[0] = nums[0];
            res[1] = nums[1];
            res[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[0])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="sum"></param>
        /// <param name="avg"></param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }
}
