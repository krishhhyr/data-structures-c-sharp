namespace Stacks
{
    internal class Program
    {
        // Declares the stack via an array.
        static int[] stack = new int[5];
        // Used to check if the stack is empty or not.
        static int top = -1;
        // Checks the number of elements in the stack.
        static int maxLength = stack.Length;
        static void Main(string[] args)
        {
            
        }
        #region Using-Arrays

        // Checks if the stack is empty.
        // If not, it decrements the counter "top"
        static void Pop() 
        {
            if (top != -1)
            {
                top--;
            }
            else 
            {
                Console.WriteLine("Stack is empty");
            }
        }

        static void Push(int item) 
        {
            if (top < maxLength - 1)
            {
                top += 1;
                stack[top] = item;
            }
            else 
            {
                Console.WriteLine("Stack is full");
            }
        }
        static void Peek() 
        {
            if (top == -1)
            {
                Console.WriteLine("Stack empty");
            }
            else 
            {
                Console.WriteLine(stack[top]);
            }
        }

        #endregion
    }
}