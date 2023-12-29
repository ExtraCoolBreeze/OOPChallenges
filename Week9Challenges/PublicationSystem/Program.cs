namespace PublicationsSystem
{
    //Main driver program
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the classes
            var book1 = new Book();

            var magazine1 = new Magazine();

            //Calling the methods and functions 

            Console.WriteLine("Publications");
            Console.WriteLine("============");
            Console.WriteLine("");

            book1.setTitle();
            book1.setAuthor();
            book1.setPublisher();

            Console.WriteLine("The title of the book is " + book1.getTitle());
            Console.WriteLine("The author of the book is " + book1.getAuthor());
            Console.WriteLine("The publisher of the book is " + book1.getPublisher());

            magazine1.setTitle();
            magazine1.setEditor();
            magazine1.setPublisher();

            Console.WriteLine("");
            Console.WriteLine("The title of the magazine is " + magazine1.getTitle());
            Console.WriteLine("The editor of the magazine is " + magazine1.getEditor());
            Console.WriteLine("The publisher of the magazine is " + magazine1.getPublisher());
            Console.WriteLine("");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();
        }
    }
}