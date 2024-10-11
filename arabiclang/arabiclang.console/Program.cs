using System;
using System.IO;
using System.Text;

namespace arabiclang.console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Characters a α क 

            //TestAscii();
            //TestGreek();
            //TestHindi();
            //TestArabic();
            TestArabicString();
            Console.Read();
        }

        static void TestAscii()
        {
            // Characters a α क 
            char a = 'a';

            Console.WriteLine($"{a} character has code: {(int)'a'}");
        }

        static void TestGreek()
        {
            char a = 'α';

            Console.WriteLine($"{a} character has code: {(int)'a'}");
        }

        static void TestHindi()
        {
            char a = 'क';

            Console.WriteLine($"{a} character has code: {(int)'a'}");

            File.WriteAllBytes("file.txt", Encoding.UTF8.GetBytes(a.ToString()));
        }

        static void TestArabic()
        {
            char a = 'م';
            Console.WriteLine($"{a} character has code: {(int)'a'}");
            File.WriteAllBytes("fileArabic.txt", Encoding.UTF8.GetBytes(a.ToString()));
        }

        static void TestArabicString()
        {
            string arabicText = "كيف حالكم";
            Console.WriteLine(arabicText);
            File.WriteAllBytes("fileArabicString1.txt", Encoding.UTF8.GetBytes(arabicText));
        }

        static void ReadArabicString()
        {
            byte[] bytes = File.ReadAllBytes("location");

            //Then to write these bytes on the screen, you can use the Encoding class of System.Text namespace, 
            //to convert them to String using an encoding. See below:
            string data = Encoding.UTF8.GetString(bytes); // accepts byte[]
            //Now the data would contain Unicode characters.You can then represent them on screen by outputting them 
            //using methods used in your own framework.


           //Console.WriteLine(data);
           
        }


        static void writeTest()
        {
            //You can also encode the data back and store in the file, 
            //you can convert the string to byte array and store all bytes to the file... Look below:

            string data = ""; //GetData(); // get the data from somewhere.
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            File.WriteAllBytes("location", bytes);
        }
    }
}
