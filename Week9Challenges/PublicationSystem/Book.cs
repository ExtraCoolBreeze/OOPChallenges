using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationsSystem
{

    //Inheriting from base class
    class Book : Publication
    {
        //variables only available though this class
        private string author;
        private string ISBN;

        //constructor

        public Book()
        {
            author = "Author";
            ISBN = "ISBN";
        }

        //getters and setters

        public void setAuthor()
        {
            Console.Write("Enter author: ");
            author = Console.ReadLine();
        }

        public void setISBN()
        {
            Console.Write("Enter ISBN: ");
            ISBN = Console.ReadLine();
        }

        public string getAuthor()
        {
            return author;
        }

        public string getISBN()
        {
            return ISBN;
        }

    }
}
