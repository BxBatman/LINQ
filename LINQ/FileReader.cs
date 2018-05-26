using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    class FileReader
    {
        private String path;
        private XElement xElement;
        private IEnumerable<XElement> books;

        public FileReader()
        {
            this.path = "../../books.xml";
            this.xElement = XElement.Load(path);
            this.books = xElement.Elements();
        }
        

        public void searchById(string id)
        {
            var idList = from idl in xElement.Elements("book")
                         where (string)idl.Attribute("id") == id
                         select idl;

            foreach (XElement xEle in idList)
            {
                Console.WriteLine("Autor: " + xEle.Element("author").Value);
                Console.WriteLine("Tytuł: " + xEle.Element("title").Value);
                Console.WriteLine("Kategoria: "+xEle.Element("genre").Value);
                Console.WriteLine("Cena: "+xEle.Element("price").Value);
                Console.WriteLine("Data publikacji: "+xEle.Element("publish_date").Value);
                Console.WriteLine("Opis: "+xEle.Element("description").Value);

            }

        }

        public void searchByPrice(double price)
        {
            var idPrice = from idp in xElement.Elements("book")
                          where (double)idp.Element("price") > price
                          select idp;

            foreach(XElement xEle in idPrice)
            {
                Console.WriteLine("Autor: " + xEle.Element("author").Value);
                Console.WriteLine("Tytuł: " + xEle.Element("title").Value);
                Console.WriteLine("Cena: " + xEle.Element("price").Value);
                
            }
        }

        public void searchByGenre(string genre)
        {
            var idGenre = from idg in xElement.Elements("book")
                          where (string)idg.Element("genre") == genre
                          select idg;

            foreach(XElement xEle in idGenre)
            {
                Console.WriteLine("Autor: " + xEle.Element("author").Value);
                Console.WriteLine("Tytuł: " + xEle.Element("title").Value);
                Console.WriteLine("Kategoria: " + xEle.Element("genre").Value);
                Console.WriteLine("Cena: " + xEle.Element("price").Value);
            }
        }
    }
}
