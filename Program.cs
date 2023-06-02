namespace DecisionTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Decision  Table*/


            Console.WriteLine("Enter the quantity amount:");

            int Qinput = Convert.ToInt32(Console.ReadLine());



            if (Qinput < 10)
            {
                Console.WriteLine("The discount you will receive is 5%");
            }
            else if (Qinput < 50)
            {
                Console.WriteLine("The discount you will receive is 10%");
            }
            else if (Qinput < 100)
            {
                Console.WriteLine("The discount you will receive is 15%");
            }
            else
            {
                Console.WriteLine("Quantity amount inserted is greater than 100.");
            }
        }
    }
}