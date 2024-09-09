namespace IfElseIfDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 51;
            if (myNumber > 50)
            {
                Console.WriteLine($"Utskrift: {myNumber} är större än 50");
            }
            else if (myNumber < 50)
            {
                Console.WriteLine("Utskrift: " + myNumber + " är mindre än 50");
            }
            else
            {
                Console.WriteLine("myNumber är lika med 50");
            }
        }
    }
}
