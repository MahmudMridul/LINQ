

namespace LINQ.DeferredExecution
{
    public class DeferredExecutionExamples
    {
        public static void ExampleOne()
        {
            List<int> nums = new List<int>() { 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 };
            //this line does not get executed here
            IEnumerable<int> smallNums = nums.Where(num => num < 50);

            Console.WriteLine("First Iteraion: ");
            foreach (int num in smallNums) /*line 17 gets executed here*/ 
            {
                Console.WriteLine(num);
            }
            nums.Add(22);
            nums.Add(26);
            nums.Add(49);
            nums.Add(44);
            nums.Add(33);

            Console.WriteLine("Second Iteraion: ");
            foreach (int num in smallNums) /*line 17 gets executed here*/
            {
                Console.WriteLine(num);
            }
        }
        
    }
}
