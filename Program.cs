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
            char[] blocks = new char[] {'{', '}', '|', '^', '[', ']', '`'}; 
            char [] queryCharacters = new char [] { ';', '/', '?', ':', '@', '&', '=', '+', '$', ',' }; 
            char[] delimeter = new char[] { '<', '>', '#', '%', '\"'};
          

            // int count = 0; // counts number of spaces 

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input[i]))

                {
                    result += "%20";
                    // count += 1; 
                }
                else if (input[i] == delimeter[0]) { 
                   
                    result += "%3C";

                }
                else if (input[i] == delimeter[1])
                {

                    result += "%3E";

                }
                else if (input[i] == delimeter[2])
                {

                    result += "%23";

                }
                else if (input[i] == delimeter[3])
                {
                    
                    result += "%25";

                }
                else if (input[i] == delimeter[4])
                {

                    result += "%22";

                }
                else
                {
                    result += input[i];
                }
            } 
            Console.WriteLine(result);
        }
    }
}
