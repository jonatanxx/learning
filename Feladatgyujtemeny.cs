using System;
using System.Text;
using System.Collections.Generic;

namespace CS_feladatgyujtemeny
{
    public partial class Program
    {

        static public void Main()
        {
            Console.Clear();

            //feladat3_1();

            //feladat3_2();
        }
        //--------------------------------------------------------------------------------------
        // feladat 3.2 
        //[Számok bekérése] Írjunk programot, mely bekér egy számot, és
        //eldönti, hogy osztható-e 3-mal, 4-gyel vagy 9-cel.
        static void feladat3_2()
        {
            int intSzam;
            Console.Clear();
            Console.WriteLine("Írj be egy számot. Megadom, hogy hogy osztható-e 3-mal, 4-gyel vagy 9-cel.");
            Console.Write("Kérem a számot: ");

            intSzam = <int>Console.ReadLine();

        }

        //--------------------------------------------------------------------------------------

        // feladat 3.1 hello  world
        static void feladat3_1()
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }


        static void feladat3_2()
        {
            // [Számok bekérése] Írjunk programot, mely bekér egy számot, és
            // eldönti, hogy osztható-e 3 - mal, 4 - gyel vagy 9 - cel.

            string strInp ="";
            string strOut = "";

            int intInp = 0;

            Console.WriteLine("Kilépés: Exit");
            Console.WriteLine("Eldööntjük osztható-e  3-mal, 4-gyel vagy 9-cel.");
            Console.WriteLine("------------------------------------------------");
            while (true)
            {
                Console.Write("Kérek egy számot: ");
                strInp = Console.ReadLine();

                //kilépés
                if (strInp.ToUpper() == "EXIT") return;

                //egész szám?
                if (!int.TryParse(strInp, out intInp))
                {
                    Console.WriteLine("Egész számot várok!");
                }
                else // egész szám
                {
                    // kiiratás alaphelyzet
                    strOut = "";

                    // osztható 3, 4, 9?
                    if (intInp % 3 == 0) { strOut = " 3"; }
                    if (intInp % 4 == 0) { strOut = strOut + " 4"; }
                    if (intInp % 9 == 0) { strOut = strOut + " 9"; }

                    Console.WriteLine("A beutött szám: {0}, osztói: " + strOut, intInp);
                }

            }

        }
//--------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------


    }

}