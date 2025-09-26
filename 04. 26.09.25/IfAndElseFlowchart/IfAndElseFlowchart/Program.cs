namespace IfAndElseFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string muutuja = Console.ReadLine();

            if (muutuja == "")
            {
                Console.WriteLine("Miks sa ei sisestanud enda nime!");
            }
            else
            {
                Console.WriteLine("Sisestasid nime " + muutuja);
            }
        }
    }
}
