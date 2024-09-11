namespace C_Fundamentals
{
    public class ArraysInReverseOrder
    {
        public void ArraysInReverseOrderFunction()
        {
            int total = 5;
            int[] numbers = new int[total];
          

            for (int i = 0; i < total; i++)
            {  
                Console.WriteLine("Enter a number and press Enter: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(numbers);
            Console.WriteLine("The Reverse Array is: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
