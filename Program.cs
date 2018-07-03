using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
           //  https://companyserver.com/content/[project_name]/files/[activity_name]/[activity_name]Report.pdf


            char[] blocks = new char[] { '{', '}', '|', '^', '[', ']', '`' };
            char[] query_characters = new char[] { ';', '/', '?', ':', '@', '&', '=', '+', '$', ',' };
            char[] delimeter = new char[] { '<', '>', '#', '%', '\"' };              Console.WriteLine("Enter Project name: ");             String Project_name = Console.ReadLine();             Console.WriteLine("Enter the activity name here: ");             String Activity_name = Console.ReadLine();             String url = "https://companyserver.com/content/";
            // int count = 0; // counts number of spaces 

         
            func(Project_name, ref url, delimeter, blocks, query_characters); 
            url += "/files/";
            func(Activity_name, ref url, delimeter, blocks, query_characters); 

            url += "/";
            func(Activity_name, ref url, delimeter, blocks, query_characters); 

            url += "Report.pdf";
            Console.WriteLine(url);

        }

        public static void func (String name, ref String url, char [] delimeter, char [] blocks,char [] queryCharacters ) 
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsWhiteSpace(name[i]))
                {
                    url += "%20";
                    // count += 1; 
                }
                else if (Char.IsControl(name[i]))
                {
                    Console.WriteLine("Invalid: Control Character");
                }
                else if (name[i] == delimeter[0])
                {

                    url += "%3C";

                }
                else if (name[i] == delimeter[1])
                {

                    url += "%3E";

                }
                else if (name[i] == delimeter[2])
                {

                    url += "%23";

                }
                else if (name[i] == delimeter[3])
                {

                    url += "%25";

                }
                else if (name[i] == delimeter[4])
                {

                    url += "%22";

                }
                else if (name[i] == blocks[0])
                {

                    url += "%7B";
                }
                else if (name[i] == blocks[1])
                {

                    url += "%7D";
                }
                else if (name[i] == blocks[2])
                {

                    url += "%7C";
                }
                else if (name[i] == blocks[3])
                {

                    url += "%5E";
                }
                else if (name[i] == blocks[4])
                {

                    url += "%5B";
                }
                else if (name[i] == blocks[5])
                {

                    url += "%5D";
                }
                else if (name[i] == blocks[6])
                {

                    url += "%5C";
                }
                else if (name[i] == queryCharacters[0])
                {

                    url += "%3B";
                }
                else if (name[i] == queryCharacters[1])
                {

                    url += "%2F";
                }
                else if (name[i] == queryCharacters[2])
                {

                    url += "%3F";
                }
                else if (name[i] == queryCharacters[3])
                {

                    url += "%3A";
                }
                else if (name[i] == queryCharacters[4])
                {

                    url += "%40";
                }
                else if (name[i] == queryCharacters[5])
                {

                    url += "%26";
                }
                else if (name[i] == queryCharacters[6])
                {

                    url += "%3D";
                }
                else if (name[i] == queryCharacters[7])
                {

                    url += "%2B";
                }
                else if (name[i] == queryCharacters[8])
                {

                    url += "%24";
                }
                else if (name[i] == queryCharacters[9])
                {

                    url += "%2C";
                }
                else
                {
                    url += name[i];
                }
              
            }


        }
    }
}
