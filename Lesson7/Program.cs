using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication Table
            /*int number;

             Console.WriteLine("Please, enter a number: ");
             number = Int32.Parse(Console.ReadLine());
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{number} X {i} = {number * i}");
             }*/

            // count sõna aga ei kasuta length vaid foreach
            /*Console.WriteLine("Enter your name please: ");
              string name = Console.ReadLine();

            /* int counter = 0; //nimi ei saa väiksem olla kui 1

             foreach (char letter in name) //loe tähed selles nimes 
             {
                 counter++; //loeb need tähed kokku
             }

             Console.WriteLine($"Your name is {counter} letters long.");*/

            //foreach-ga loeme iga elemendi ära

            /* bool letterFound = false; // ei ole leitud
             foreach(char letter in  name)
             {
                 if (letter == 'a') // char jaoks on vaja ' ' märk
                 {

                     letterFound = true; //otsib kas nimes on letter A
                     break;
                 }                
             }
            /* if (letterFound) // kui letter on leitud 
             {
                 Console.WriteLine("Name includes letter A"); // siis includes A
             }

             else
             {
                 Console.WriteLine("Name doesnt include letter A"); // doesnt include A
             }*/

            /* string result = letterFound ? "Includes letter A" : "Doesnt include letter A";
             Console.WriteLine(result); */

            /* int aTotal = 0;
             string name;
             Console.WriteLine("Please, enter name: ");
             name = Console.ReadLine();

             for (int i = 0; i < name.Length; i++)
             {
                 if (name[i] == 'a')
                 {
                     aTotal++;
                 }

             }

             Console.WriteLine($"There are {aTotal} \"A\" letters in your name.");*/

            /* string name;
             Console.WriteLine("Please, enter your name: ");
             name = Console.ReadLine();*/
            /* foreach (char letter in name)
             {
                 Console.Write($"{letter} "); // write jääb ühele reale, ja peale letter vahe
             }
             */

            /* for (int i = 0; i < name.Length; i++) // teeb ringi niikaua kui i ei ole võrdne name.Length-1
             {
                 if (i == name.Length-1)
                 {
                     Console.Write($"{name[i]}"); // name-Length-1 ehk Ksenia-1 on täidetud siis tuleb siia reale ja ei lisa midagi lõpu.
                     break;
                 }

                 Console.Write($"{name[i]}*"); //kirjutab igale tähele * taga nii kaua kui Ksenia-1 ei ole täidetud
             }
             */


            /* int i = 1;

             while (i <= 10)
             {
                 Console.WriteLine(i);
                 i++;
             } */

            string hello = "hello";
            int i = 0;

            while (i < hello.Length)
            {
                Console.Write($"{hello[i]}*");
                i++;
            }


            Console.ReadLine();

        }
    }
}
