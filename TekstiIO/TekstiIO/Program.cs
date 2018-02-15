using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstiIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character stream writing
            /*
                        try
                        {
                            StreamWriter writer = File.CreateText("c:\repositories\myfile.txt");
                            writer.WriteLine("Out to file.");
                            writer.Close();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("**********" + "\n" + ex.Message + "\n" + "**********");
                        }                                     */
            // Character stream reading

            StreamReader reader = null;
            try
            {
                reader = File.OpenText(@"c:\repositories\myfile.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    String[] sanat = line.Split(';', ' ');
                    //Erottelee sanoista välilyönnit ja puolipisteet
                    Console.WriteLine(sanat[3]+", "+sanat[2]+" "+sanat[0]);  //tulostaa ensin rivin vimmeisen sanan[3], sitten kolmannen[2] ja viimeksi ensimäisen[0] 0= eka
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("**********" + "\n" + ex.Message + "\n" + "**********");
            }
            finally
            {
               if(reader!=null) reader.Close();
            }

        }
    }
}
