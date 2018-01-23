using System.Collections;

namespace C1P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //input string 
            string inputString = "taco cat";

            Hashtable dictionary = new Hashtable();

            foreach (char character in inputString.ToCharArray())
            {
                dictionary.Add(character, (int)character);
            }
        }
    }
}
