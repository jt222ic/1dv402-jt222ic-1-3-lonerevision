using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ic_1._3
{
    class Program
    {

        static void Main(string[] args)
        {
            int Salaries;
            Salaries = Readint("Ange antal löner som ska bearbetas:");////Ange löner här
            Console.WriteLine("");

            ProcessSalaries(Salaries);








        }
        static void ProcessSalaries(int count)
        {
            int[] SalariesArray = new int[count];
            for (int i = 0; i < SalariesArray.Length; ++i)                   //// loop för inskrivning
            {

                SalariesArray[i] = Readint("Ange lön nummer" + (i + 1) + ":");

            }
            int[] klonapengar = (int[])SalariesArray.Clone();

            Array.Sort(SalariesArray);                                       ////// Löneskillnaden
            int diffrence = SalariesArray.Max() - SalariesArray.Min();

            Console.WriteLine("");                                                       //// medelvärdet , payment.Average())
            Console.WriteLine("-----------------------------");

            if (SalariesArray.Length % 2 == 0)
            {
                int form1 = SalariesArray.Length / 2;
                int form2 = SalariesArray.Length / 2 - 1;
                int median = (SalariesArray[form1] + SalariesArray[form2]) / 2;       ///// Medianform för både uträkningar
                Console.WriteLine("MedianLön:          {0:c0}", median);
            }

            else if (SalariesArray.Length % 2 == 1)
            {
                int unevenMedian = SalariesArray.Length / 2;
            }




            Console.WriteLine("Medellön   :          {0:c0}", SalariesArray.Average());
            Console.WriteLine("Lönespridningen:       {0:c0}", diffrence);
            Console.WriteLine("------------------------------");
            for (int p = 0; p < SalariesArray.Length; ++p)
            {
                if (p % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("    {0,5}", klonapengar[p]);

            }

            Console.WriteLine();


        }
        static int Readint(string prompt)
        {
            bool Loop = false;
            int bantanty= 0;
            do
            {
                string input;
                Console.Write(prompt);
                input = Console.ReadLine();
                try
                {
                    bantanty = int.Parse(input);
                    Loop = false;
                }
                catch                                                         /// while med try catch och do
                {
                    Console.WriteLine();                                    ///// inmatning för feluttryck
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! {0} kan inte tolkas som ett heltal", input);   
                    Console.ResetColor();
                    Console.WriteLine();
                    Loop = true;                                          ////lärde mig att använda bool
                                                                          // användning av prompt o
                                                                          

                }
            } while (Loop == true);



            return bantanty;




        }

    }
}

            

         

     
    
    


