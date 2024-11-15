namespace TypeParametersAndGenerics
{
    internal partial class Program
    {
        public static T GetLastList<T>(T[] inputArray)
        {
            //return inputArray[inputArray.Length - 1];
            return inputArray[^1];
        }

        static void Main(string[] args)
        {

            //int[] intArray = { 1, 5, 2, 8, 6 };
            //Console.WriteLine(GetLastList(intArray)); // 6

            //double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            //Console.WriteLine(GetLastList(doubleArray)); // 6.1111

            //string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            //Console.WriteLine(GetLastList(stringArray)); // "northcoders"

            //Stack<string> myStack = new Stack<string>();
            //myStack.Push("hello");
            //myStack.Push("world");
            //myStack.Push("today");

            ////myStack.Pop();
            //Console.WriteLine(myStack.Count);
            //foreach (string item in myStack)
            //{
            //    Console.WriteLine(item);
            //}


            var myBooks = new CustomStack<string>();

            myBooks.Push("Book 1");
            myBooks.Push("Book 2");
            myBooks.Push("Book 3");

            Console.WriteLine(myBooks.Pop()); // Book 3

        }
    }
}
