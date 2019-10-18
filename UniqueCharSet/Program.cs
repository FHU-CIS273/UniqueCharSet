using System;

namespace UniqueCharSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Zavier has a girlfriend.";

            bool result = s.IsUniqueCharacterSet();

            Console.WriteLine(result);

        }


    }
}
