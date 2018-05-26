using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Menu
    { FileReader fileReader;
        public void showMenu()
        {
            int choose = 0;
            do
            {
                fileReader = new FileReader();
                Console.WriteLine("------MENU------");
                Console.WriteLine("Wyszukaj po: ");
                Console.WriteLine("1.Id - dane o książce");
                Console.WriteLine("2.Cena - większa od");
                Console.WriteLine("3.Kategoria - dane o książce");
                Console.WriteLine("4.Kategoria i cena -dane o ksiązce");
                Console.WriteLine("0.Wyjdź");
                Console.WriteLine();
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Źle podane dane!");
                }

                if (choose != 0)
                {
                    chooseExecute(choose);
                }
            } while (choose != 0);
            
        }

        private void chooseExecute(int choose)
        {
            
            
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Podaj id");
                    string id = Console.ReadLine();
                    Console.WriteLine();
                    fileReader.searchById(id);
                    break;
                case 2:
                    Console.WriteLine("Podaj cene");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    fileReader.searchByPrice(price);
                    break;
                case 3:
                    Console.WriteLine("Podaj kategorie");
                    string cat = Console.ReadLine();
                    Console.WriteLine();
                    fileReader.searchByGenre(cat);
                    break;
                case 4:
                    Console.WriteLine("Podaj kategorie");
                    string cat2 = Console.ReadLine();
                    Console.WriteLine("Podaj cene");
                    double price2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    fileReader.searchByGenreAndPrice(cat2, price2);
                    break;
                        
            }
            
        }
    }
}
