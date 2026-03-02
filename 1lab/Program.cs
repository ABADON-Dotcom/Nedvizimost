namespace _1lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string test_data = "RealEstate Ivanov 2020.01.15 5000000";

            Logic logic = new Logic();

            logic.PrintRealEstate(logic.ToRealEstate(test_data));
        }
    }
}