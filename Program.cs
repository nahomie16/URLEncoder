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
            String [] blocks = new String[] { "{", "}", "|", "^", "[", "]", "`"};
            String [] queryCharacters = new string[] { ";", "/", "?", ":", "@", "&", "=", "+", "$", ","};
            String[] delimeter = new string[] { "<", ">", "#", "%", "\"" }; 

           // int count = 0; // counts number of spaces 

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input[i]))
              
                {
                    result += "%20"; 
                    // count += 1; 

                }
                else if (true)  {  // if input is control_char
                    // print invalid 
                
                }
                else if (true) //  input is delimeter 
                { 
                
                    // Convert delimeter to "%3c" 
                }
                else if (true) { // input is block 
                       // convert to url encoded format 
                
                
                }


                else if (true) { // input is query_characters 
                    // convert to url encoded format 

                }
                else
                {
                    result += input[i];
                    // count = 0; 
                }
            }
            Console.WriteLine(result);
           //  Console.WriteLine("Number of spaces = {0} ", count);


            // Console.WriteLine(input); 

        }
    }
}
