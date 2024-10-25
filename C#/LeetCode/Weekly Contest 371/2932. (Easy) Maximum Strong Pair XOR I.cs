using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_371
{
    public class Solution2932 {
        public bool isStrongPair(int a, int b){
            if (Math.Abs(a - b) <= Math.Min(a, b))
                return true;
        
            return false;
        }
    
        public int MaximumStrongPairXor(int[] nums) {
            int n = nums.Length;
            int max = 0;
            for (int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if (isStrongPair(nums[i], nums[j]))
                        if (max < (nums[i] ^ nums[j]))
                            max = (nums[i] ^ nums[j]);
                }
            }
        
            return max;
        }
    }
}
