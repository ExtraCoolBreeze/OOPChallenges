using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationsSystem
{
    //creating a base class
    class Publication
    {
        //read only attributes
        protected string title;
        protected string publisher;

        //constructor
        public Publication()
        {
            title = "Title";
            publisher = "Publisher";
        }
        
        //getters and setters
        public void setTitle()
        {
            Console.Write("Enter title: ");
            title = Console.ReadLine();
        }

        public void setPublisher()
        {
            Console.Write("Enter publisher: ");
            publisher = Console.ReadLine();
        }

        public string getTitle()
        {
            return title;
        }

        public string getPublisher()
        {
            return publisher;
        }

    }

}
