using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
           /* Console.Write("Imię: "); //wyświetli imię
            Console.WriteLine("Janusz");*/
            /*Komentarz
             *w wielu
             *liniach
             */

            /*
             * #
             * ##
             * ###
             * ####
             */
            /*Console.WriteLine("#\n##\n###\n####");*/

           /* string name;
            name = "Kasia";
            Console.WriteLine("\n Your name: " + name);// + konkatenacja
            Console.WriteLine("\nYour name: {0}",name);

            int age;
            age = 20;

            Console.WriteLine("\n Your name: {0}\n Your age: {1}",name,age);

            sbyte age1 = 20;
            Console.WriteLine("\nWiek: {0}", age1);*/

            /*
             * Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu*/

           /* Console.Write("\nPodaj bok a: ");
            string a = Console.ReadLine();
            //Console.WriteLine("\n a: {0}",a);
            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("\nPole wynosi :"+result);*/

            /*
             * Oblicz pole trójkąta
             * Dane podaje user z klawiatury*/

            Console.WriteLine("\nPodaj a: ");
            string b = Console.ReadLine();
            Console.WriteLine("\na wynosi {0}. Podaj h: ", b);
            string h = Console.ReadLine();
            double result2 = double.Parse(b) * double.Parse(h);
            result2 = result2 / 2;
            Console.WriteLine("\nWynik: "+result2);

            Console.ReadKey();

        }
    }
}
