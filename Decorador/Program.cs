using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string res;
            bool salir = false;
            int i = 0;
            Beverage beverage;
            Beverage[] b = new Beverage[0];
            List<Beverage> ls = b.ToList();
            /*Beverage beverage2 = new Espresso();
            Console.WriteLine(beverage2.getDescription()
            + " $" + beverage2.cost());

            Beverage beverage1 = new HouseBlend();

            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            Console.WriteLine(beverage1.getDescription()
            + " $" + beverage1.cost());*/

            //Beverage beverage;
            Console.WriteLine("Buen dia. Bienvenido a Starbuzz!");
            Console.ReadKey();
            while (salir==false)
            {
                Console.Clear();
                Console.WriteLine("\nTenemos los siguientes tipos de cafe:\n1.- Espresso.\n2.- House Blend.\n3.- Dark Roast.");
                Console.Write("Cual es seria su eleccion? ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        beverage = new Espresso();
                        ElegirCondimento(beverage);
                        
                        break;
                    case 2:
                        beverage = new HouseBlend();
                        ElegirCondimento(beverage);
                        break;
                    case 3:
                        beverage = new DarkRoast();
                        ElegirCondimento(beverage);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Escoge del 1 al 3!!!");
                        break;
                }

                i++;
                Console.Write("Quieres terminar tu orden? (S/N)");
                res = Console.ReadLine();
                if (res == "S")
                {
                    salir = true;
                    
                }
                else if (res == "N")
                {
                    salir = false;
                }
                else
                {
                    Console.Write("Escribe: S o N");
                }
            }
            GenerarOrden();

            void ElegirCondimento(Beverage beverage)
            {
                string r;
                bool fin = false;
                
                while (fin == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nTenemos los siguientes condimentos:\n1.- Mocha.\n2.- Soy.\n3.- Wip.");
                    Console.Write("Cual es seria su eleccion? ");
                    opc = Int32.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            beverage = new Mocha(beverage);
                            
                            break;
                        case 2:
                            beverage = new Soy(beverage);
                            break;
                        case 3:
                            beverage = new Wip(beverage);
                            break;
                        default:
                            Console.WriteLine("Escoge del 1 al 3 o Termina tu orden!!!");
                            break;
                    }
                    
                    Console.Write("Quieres elegir mas condimentos? (S/N)");
                    r = Console.ReadLine();
                    if (r == "N")
                    {
                        fin = true;
                    }
                    else if(r == "S")
                    {
                        fin = false;
                    }
                    else
                    {
                        Console.Write("Escribe: S o N");
                    }
                }
                ls.Add(beverage);
            }

            void GenerarOrden()
            {

                //foreach (var grouping in ls.GroupBy(t => t).Where(t => t.Count() == 1))
               
                foreach (var grouping in ls.GroupBy(t => t.getDescription()).Where(t => t.Count() == 1))
                {
                    Console.WriteLine(string.Format("{0} {1}.", grouping.Count(), grouping.Key));
                }
            }
            Console.ReadKey();
        }
    }
}
