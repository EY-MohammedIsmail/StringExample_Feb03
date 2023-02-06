using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample_Feb03
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Hello";
            String str2 = "World";
            String trimString = "   HEllo     ";
            Console.WriteLine("Length of string: "+ str.Length);

           // String concatString = (String)str.Concat(str2);
           Console.WriteLine("concatination of string: " + String.Concat(str,str2 ));

            Console.WriteLine("indexOf of string: " + str.IndexOf("l"));

            Console.WriteLine("UpperCase of string: " + str.ToUpper());

            Console.WriteLine("Lowercase of string: " + str.ToLower());

            Console.WriteLine("Trim of string: " + trimString.Trim());

            // Console.WriteLine("Split function : " + str.Split());

            string text = "a::b::c::d::e";

            // split string at ::
            string[] result = text.Split("::");

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.Write(str + ", ");
            }





        }
    }
}
