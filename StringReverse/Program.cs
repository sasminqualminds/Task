namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string word=Console.ReadLine();
            
            for(int i=word.Length-1;i>=0; i--)
            {
                Console.Write(word[i]+"");
            }
            
        }
    }
}
