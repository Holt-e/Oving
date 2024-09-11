namespace C_Fundamentals
{
    public class CalculateValuesOfAFunction
    {
        public void CalculateValuesOfAFunctionFunction()
        {
            Console.WriteLine("Enter the value of x1 and x2: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y;

            for (int x=x1; x <= x2; x++)
            {
                y = x * x - 2 * x + 1;
                Console.WriteLine("{0}", y);
            }
           
        }
    }
}
