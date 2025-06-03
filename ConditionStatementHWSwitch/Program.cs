namespace ConditionStatementHWSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string? firstName = Console.ReadLine();
            bool isValid = int.TryParse(firstName, out int numberName);
            while (firstName == "" || isValid == true)
            {
                Console.WriteLine("Please enter your actual name.");
                Console.Write("What is your name: ");
                firstName = Console.ReadLine();
                isValid = int.TryParse(firstName, out numberName);
                switch (isValid)
                {
                    case false:
                        break;
                    default:
                        continue;
                }
                break;
            }
            switch (firstName.ToLower())
            {
                case "tim" or "timothy":
                    Console.WriteLine("Hello Professor");
                    break;
                default:
                    Console.WriteLine("Hello Student");
                    break;
            }
        }
    }
}
