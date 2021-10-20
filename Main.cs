using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace main
{
    
    public class MainClass
    {
        
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<string> output = new List<string>();
            
            //int pointer = 0;
            
            try
            {
                using (StreamReader sr = new StreamReader("src.txt"))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                
                foreach (string s in lines)
                {
                    string[] split = s.Split(' ');
                    
                    switch (split[0])
                    {
                        case "print":
                            char[] array = split[1].ToCharArray();
                            string outp = "";
                            
                            foreach (char c in array)
                            {
                                int ascii = (int) c;
                                int counter = 0;
                                /*
                                for (int i = 0; i < ascii; i++)
                                {
                                    outp += "+";
                                    counter++;
                                }
                                outp += ".";
                                
                                while (counter > ascii)
                                {
                                    Console.WriteLine("a");
                                    outp += "-";
                                    counter--;
                                }
                                */
                                
                                
                            }
                        
                        output.Add(outp + "\n");
                        break;
                    }
                }
                
                // Write
                
                using (StreamWriter sw = new StreamWriter("out.bf"))
                {
                    foreach (string str in output)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
