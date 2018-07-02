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
                else if (input[i] == delimeter[0])
                {

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
                else if (input[i] == blocks[0])
                {

                    result += "%7B";
                }
                else if (input[i] == blocks[1])
                {

                    result += "%7D";
                }
                else if (input[i] == blocks[2])
                {

                    result += "%7C";
                }
                else if (input[i] == blocks[3])
                {

                    result += "%5E";
                }
                else if (input[i] == blocks[4])
                {

                    result += "%5B";
                }
                else if (input[i] == blocks[5])
                {

                    result += "%5D";
                }
                else if (input[i] == blocks[6])
                {

                    result += "%5C";
                }
                else if (input[i] == queryCharacters[0])
                {

                    result += "%3B";
                }
                else if (input[i] == queryCharacters[1])
                {

                    result += "%2F";
                }
                else if (input[i] == queryCharacters[2])
                {

                    result += "%3F";
                }
                else if (input[i] == queryCharacters[3])
                {

                    result += "%3A";
                }
                else if (input[i] == queryCharacters[4])
                {

                    result += "%40";
                }
                else if (input[i] == queryCharacters[5])
                {

                    result += "%26";
                }
                else if (input[i] == queryCharacters[6])
                {

                    result += "%3D";
                }
                else if (input[i] == queryCharacters[7])
                {

                    result += "%2B";
                }
                else if (input[i] == queryCharacters[8])
                {

                    result += "%24";
                }
                else if (input[i] == queryCharacters[9])
                {

                    result += "%2C";
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
