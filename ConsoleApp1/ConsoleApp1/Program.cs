using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rivit = new List<string>();

            StreamReader reader = File.OpenText(@"C:\repositories\myfile.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                rivit.Add(line);
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();

            //TODO: muokkaa
            for (int i = 0; i < rivit.Count; i++)
            {
                rivit[i]=rivit[i].ToUpper(); //muuttaa kirjaimet isoiksi
            }


                StreamWriter writer = File.CreateText(@"C:\repositories\myfile.txt");
            for (int i = 0; i < rivit.Count; i++)
            {
                writer.WriteLine(rivit[i]);
            }
            writer.Close();
            
        }
    }
}
