using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a sting: ");
            String input = Console.ReadLine();
            String result = "";

            // int count = 0; // counts number of spaces 

            for (int i = 0; i < input.Length; i++)
            {

                if (Char.IsWhiteSpace(input[i]))
                {
                    result += "%20"; 
                    // count += 1; 

                }
                else
                {
                    result += input[i];
                    // count = 0; 
                }
            }
            Console.WriteLine(result);
            // Console.WriteLine("Number of spaces = {0} ", count);


            // Console.WriteLine(input); 

        }
    }
}
