

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of linked lists
            List<string>[] data = new List<string>[100];
            // Initialise linked list
            for (int i = 0; i < data.Length; i++) 
            {
                data[i] = new List<string>();
            }
            // Adds input to the array
            string word = Console.ReadLine();

            int num = HashNumber(word, data.Length);

            data[num].Add(word);

            foreach (var element in data[num]) 
            {
                Console.WriteLine(element);
                Console.WriteLine(num);
            }
        }

        static int HashNumber(string key, int length) 
        {
            int hashValue = 0;
            int sum = 0;
            for (int i = 0;i < key.Length;i++) 
            {
                sum = sum + System.Convert.ToInt32(key[i]);
            }

            hashValue = sum % length;
            return hashValue;
        }
    }
}