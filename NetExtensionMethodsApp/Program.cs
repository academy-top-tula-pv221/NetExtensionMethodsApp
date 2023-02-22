namespace NetExtensionMethodsApp
{
    internal partial class User
    {
        public int Age { get; set; }
        public partial void PrintName()
        {
            Console.WriteLine(Name);
        }
    }

    public static class StringExtension
    {
        public static bool IsChar(this string str, char ch)
        {
            foreach(char c in str)
                if(c == ch) return true;
            return false;
        }
        public static int CountChar(this string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
                if (c == ch) count++;
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world";
            char ch = 'w';
            bool f = str.IsChar(ch);

            Console.WriteLine(f);
            Console.WriteLine(str.CountChar('l'));

            User user = new() { Name = "Bob", Age = 23 };
        }
    }
}