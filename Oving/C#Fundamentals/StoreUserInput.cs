namespace C_Fundamentals
{
    public class StoreUserInput
    {
        public void StoreUserInputFunction() 
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name);
            Console.WriteLine($"Nice to meet you, {name}");
        }
    }
}
