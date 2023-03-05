namespace Arrays
{
    //Test
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single-Dimensional-Arrays
            //Array Declaration

            //Implictly Typed Array
            string[] words = { "House", "Road", "Mouse", "Sleep", "Chicken" };

            //Declaration by element type
            int[] scores = new int[10]; 
            scores[0] = 0;
            scores[1] = 1;
            scores[2] = 2;

            //Array User Input
            string[] students = new string[10];
            for (int k = 0; k < students.Length; k++) 
            {
                //Defensive Programming
                string? input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input))
                    students[k] = input;
            }

            //Ascending Array Output
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //Descending Array Ouput
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            #endregion
            #region MultiDimensional-Arrays
            //Array Declaration

            //Two-dimensional array
            //Four rows and two columns
            int[,] table = new int[4, 2];

            //Three-dimensional array 
            //Two arrays which both have three rows and four columns
            int[,,] table3D = new int[2, 3, 4];
            #endregion

        }
    }
}