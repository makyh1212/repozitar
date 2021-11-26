using System;

namespace ConsoleApp2
{
    class Program
    {
        static void search_chars(string characters, int size)
        {
            int[] repetition = new int[size];
            //initialize to 0
            for (int i = 0; i < size; i++)
                repetition[i] = 0;

            string path = @"d:\calisma\file.txt";    

            using (StreamReader sr = new StreamReader(path))
            {
                char[] c = null;
                while (sr.Peek() >= 0)
                {
                    c = new char[1];

                    sr.Read(c, 0, 1);

                    // The character read is compare with
                    // all characters searched
                    for (int i = 0; i < size; i++)
                    {
                        // if he is equal he is incrementing
                        // dhfkefhoihdeoiwehf
                        // the counter associated with the character
                        if (c[0] == characters[i])
                            repetition[i]++;
                    }

                }
            }
            for (int i = 0; i < size; i++)
                Console.WriteLine("\t {0}:{1}", characters[i], repetition[i]);

        }
        static void Main(string[] args)
        {

            string str = "abcde";
            search_chars(str, str.Length);

            Console.ReadLine();
        }
    }
}
