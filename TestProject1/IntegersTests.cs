using System.Collections.Generic;

namespace TestProject1
{
    public class IntegersTests
    {
        public static int DigitalRoot(int number)
        {
            if (number < 10) {
                return number;
            }

            int sum = 0;
            while (number != 0) {
                sum += (number % 10);
                number /= 10;
            }

            return DigitalRoot(sum);
        }
        
        public static int CountNumbersPairs(List<int> array, int target) {
            int count = 0;
            for(int i = 0; i < array.Count; ++i) {
                for(int j = i + 1; j < array.Count; ++j) {
                    if(array[i] + array[j] == target) {
                        count++;
                    }
                }
            }
            return count;
        }
        
        
    }
}