using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = new int[2];
            string[] poc = new string [2];
            string P = "";
            int Mnp = 0;
            int Mxp = 0;

            tweet[] t = new tweet[10];

            for (int i = 0;i < t.Length ;i++)
            {
                t[i].text = "qout"+i;
                t[i].time = 10.0 +i/10;
            }

            Console.WriteLine("Enter Mnp OF time && Mxp of time ");

            P = Console.ReadLine();

            for (int i = 0; i < t.Length; i++)
                ;

            Mnp = Convert.ToInt32(Console.ReadLine());
            Mxp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t.Length; i++)
            {
                if(Mnp > t[i].time && Mxp < t[i].time)
                {
                    Console.WriteLine(t[i].text);
                }
            }
            
            Console.ReadKey(true);
        }
        struct tweet
        {
            public string text;
            public double time;
        }
    }
}





/*----- TRASH ---------- TRASH --------- TRASH ---------- TRASH ----------- TRASH --------- TRASH ---------- TRASH  
string b = "?Hai"; 

            foreach(int coc in a)
            {
                Console.WriteLine("Kon'nichiwa!!!");
            }

            foreach(char took in b)
            {
                Console.WriteLine("Arigatō");
            }

            for (int i = 0; i < 10; i++)
            {
                 nbt[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            for (int i = 0; i < t.Length; i++)
            {
                zont[i] = Console.ReadLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (nbt[i] == t[i].time)
                {
                    Console.WriteLine(zont[i]);
                }
            }
                        double[] nbt = new double[10];
            string[] zont = new string[10];

    
            tweet g = new tweet();
            g.text = "Xtwo";
            g.time = 10.30 ;
            tweet g = new tweet();
            g.text = "Xtwo";
            g.time = 10.30 ;
------- TRASH ---------- TRASH --------- TRASH ---------- TRASH ----------- TRASH --------- TRASH ---------- TRASH  
*/
