namespace Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string"); //qwer
            string str=Console.ReadLine();

            Dictionary<char,int> dict = new Dictionary<char,int>();

            foreach(char i in str)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else {
                    dict[i] = 1;
                }
            }
            foreach(var pair in dict)
            {
                Console.WriteLine($" {pair.Key} : {pair.Value} ");
            }
        }
    }
}
