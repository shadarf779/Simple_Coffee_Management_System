using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halkawt_Ali__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shop Assignment             
            Console.WriteLine("* This is the menu *");
            //Userm agadar krdotawa laway ka ama menui xorak w xwardnawakana 
            Console.WriteLine(" Order        | Prices $");
            // ba USerm wtwa ka awa stwni dawakrawakana w stwni dwam nrxakanyati
            Console.WriteLine("1 - Water     | 1$        ");
            //nrxi aw 1 dollar 
            Console.WriteLine("2 - Fish      | 5$         ");
            //nrxi fish 5 dollar
            Console.WriteLine("3 - Rice      | 2.5$       ");
            //nrxi brnj 2 dollar w new 
            Console.WriteLine("4 - Hamburger | 4$    ");
            //nrxi hambargr 4 dollar
            Console.WriteLine("5 - Entrees   | 2$      ");
            //nrxi Entrees 2 dollar
            Console.WriteLine("6 - Milk      | 1.5$       ");
            //nrxi sher 1 dollar w new 
            Console.WriteLine("7 - Cake      | 3$         ");
            //nrxi Cake 3 dollar

            Console.Write("Please tell us how many meals you will eat : ");
            //lera User agadar dakaynawa laway ka chnad zhama xorak dawadakat ka dayawet 
            int MealsNum = Convert.ToInt32(Console.ReadLine());
            //nrxi mealNum bakardet bo dawakrdni zhmarai zhmaxorakakan

            //
            int menu = 1;
                // menu yaksana ba yak Chunka dabet menu nrxeki habet agarna Erorr adat . wa agar nrxi menu yaksan bet ba 0 awa Rastaxo loopaka kotay pe det
            double FoodSum = 0;
            //Koy xorakakan
            double FoodPrice = 0;
            // FoodPrice bakardet bo danani nrxy xwardnakan
            do
            {
                
                Console.Write("Please choose one of the foods on the menu : ");
                //lera dawa la User dakayn ka zhmarai menuakan bnwsin
                 menu = Convert.ToInt32(Console.ReadLine());
                // nrxi menu Convert dakayn bo ToInt32
                switch (menu)
                    //lera switch case bakardahenin bo awai zhmarai menuakaman pe bdat 
                {
                    case 0:
                        Console.WriteLine("You ACCEPT the Order ");
                        //ba USer daleyn ka ba dawakaryaka razi bwa
                        break;   
                    case 1:
                        //User 1 daxl bkat awa aw bo User denet Chunka la naw menuaka zhmara yak awa 
                        FoodPrice = 1;
                        //nrxi xman yaksan krd ba yak ka nrxi awakaya 
                        Console.WriteLine($"Water = {FoodPrice}$");
                        // ba User daleyn ka nrxi aw yaksana ba 1 dollar
                        break;

                    case 2:
                        FoodPrice = 5;
                        //masi 5 dollara
                        Console.WriteLine($"Fish = {FoodPrice}$");
                        //ba User dalyn ka nrxi masi 5 dollara
                        break;
                    case 3:
                        FoodPrice = 2.5;
                        //nrxi brnj 2.5 dollara
                        Console.WriteLine($"Rice = {FoodPrice}$");
                        break;
                    case 4:
                        FoodPrice = 4;
                        //nrxi hambargr 4 dollara
                        Console.WriteLine($"Hamburger = {FoodPrice}$");
                        //ba User daleyn nrxi hamburgr 4 dollara
                        break;
                    case 5:
                        FoodPrice = 2;
                        //nrxi  Entrees 2 dollara
                        Console.WriteLine($"Entrees = {FoodPrice}$");
                        // ba User daleyn ka nrxi Entrees 2 dollra
                        break;
                    case 6:
                        FoodPrice = 1.5;
                        //nrxi Sher 1.5 dollara
                        Console.WriteLine($"Milk = {FoodPrice}$");
                        //ba User daleyn ka sher nrxi 1.5 dollara
                        break;
                    case 7:
                        FoodPrice = 3;
                        // nrxi cake 3 dollara
                        Console.WriteLine($"Cake = {FoodPrice}$");
                        //ba User daleyn ka nrxi cack 3 dollara
                        break;
                    default:
                        //agar zhmarayaki try daxl krd User 
                        Console.WriteLine("We don't Have this choice in menu sorry ");
                        //awa ba User daleyn ka aw xw xwrnaman la badast nakawet
                        break;
                }
                if (menu != 0)
                    //agar menu yaksan nabet bet ba sft 
                { 
                Console.WriteLine("- Press 0 To accept the Order");
                }
                //ba User dalaen agar 0 daxl bkat awa loopaka kotay pe det
                FoodSum += FoodPrice;
                //koy xowadnakan yaksana ba koy  nrxi xorakakan 
                
            } while (menu!=0);
            //
            Console.WriteLine($"The total : {FoodSum}$");
            //la kotayda xoy nrxi xorakani ba User daleyn

            Console.ReadKey();

        }
    }
}
