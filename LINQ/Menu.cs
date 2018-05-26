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
            fileReader = new FileReader();
            Console.WriteLine("------MENU------");
            Console.WriteLine("Wyszukaj po: ");
            Console.WriteLine("1.Id - dane o książce");
            Console.WriteLine("2.Cena - większa od");
            Console.WriteLine("3.Kategoria - dane o książce");
            int choose = Convert.ToInt32(Console.ReadLine());
            chooseExecute(choose);

            
        }

        private void chooseExecute(int choose)
        {
            Console.WriteLine("Podaj wartość");
            switch (choose)
            {
                case 1:
                    string id = Console.ReadLine();
                    
                    fileReader.searchById(id);
                    break;
                case 2:
                    double price = Convert.ToDouble(Console.ReadLine());
                    fileReader.searchByPrice(price);
                    break;
                case 3:
                    string cat = Console.ReadLine();
                    fileReader.searchByGenre(cat);
                    break;
                        
            }
            
        }
    }
}
