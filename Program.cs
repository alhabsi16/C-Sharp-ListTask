namespace C_Sharp_ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Task 1. Write a program that takes a list of integers as input and removes duplicate numbers,
            keeping only the unique elements. Implement a method that accepts the list and returns 
            a new list containing only the unique elements in the original order.

            */
            Console.WriteLine("Task 1. Write a program that takes a list of integers as input and removes duplicate numbers," +
                "\r\nkeeping only the unique elements. Implement a method that accepts the list and returns " +
                "\r\na new list containing only the unique elements in the original order.");

            Console.WriteLine();
            Console.WriteLine("==========================");

            List<int> listWithDuoblicate = new List<int> {1 , 2, 3, 4, 3, 3, 2, 6, 8, 9 , 7, 8, 5 };
            Console.WriteLine("With Duplicate Numbers");
            foreach (int element in listWithDuoblicate)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Without Duplicate Numbers");

            List<int> listWithoutDuoblicate = listWithDuoblicate.Distinct().ToList();


            foreach (int element in listWithoutDuoblicate)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Without Duplicate Numbers, With sort");
            listWithoutDuoblicate.Sort();
            foreach (int element in listWithoutDuoblicate)
            {
                Console.WriteLine(element);
            }
        }

    }

}
