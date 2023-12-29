using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationsSystem
{
    //Inheriting from base class

    class Magazine : Publication
    {
        //variable only accessible from within this class
        private string editor;

        // Constructor
        public Magazine()
        {
            editor = "Editor";
        }

        //getters and setters

        public void setEditor()
        {
            Console.Write("Enter editor: ");
            editor = Console.ReadLine();
        }

        public string getEditor()
        {
            return editor;
        }

    }
}