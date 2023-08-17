using System.Security.Cryptography.X509Certificates;

namespace Teset
{
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int length = num_list.Length;
            int[] answer = null;
            for ( int i = 0; i < length; i++)
            {
                answer[i] = num_list[length - 1 - i];
            }
            return answer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num_list = new int[] { 1, 2, 3, 4, 5 };
            Solution solution = new Solution();
            int[] result  = solution.solution(num_list);
            foreach( int i in result)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}

