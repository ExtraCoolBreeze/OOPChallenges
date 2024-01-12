namespace ConstructorsChallenge
{
    class Age
    {
        // Declare variables - private
        private int age;

        // Constructor with parameter
        public Age(int myAge)
        {
            this.age = myAge;
        }

        //Added second constructor
        public Age()
        {
            this.age = 0;
        }

        //added set age function
        public void set_age(int newAge)
        {
            this.age = newAge;
        }

        // Methods
        public int get_age()
        // Returns age of user
        {
            return age;
        }

        public void print_age()
        // Displays the age of the user
        {
            Console.Write("My age is " + get_age());
        }

        static void Main(string[] args)
        // Main program
        {   //instantiating an object
            Age natalie = new Age(21);

            //using a function or behaviour of the natalie object
            natalie.print_age();

            //instantiating the craig object
            Age craig = new Age();

            Console.WriteLine("\nPress any button to continue...\n");
            Console.ReadLine();
            Console.Write("Enter your age: ");
            int ageInput = int.Parse(Console.ReadLine());

            // Set the age using the set_age method
            craig.set_age(ageInput);

            // Display the age of the user
            craig.print_age();
        }
    }
}
