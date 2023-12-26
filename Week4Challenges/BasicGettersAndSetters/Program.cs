public class BasicGettersAndSetters
{
    public static void Main(String[] args)
    {
        //Calling the class and its functions within main
        Square s1 = new Square();
        s1.set_length(3);
        Console.WriteLine("s1 length: " + s1.get_length());
        Console.WriteLine("s1 area: " + s1.get_area());
    }
}

//separate square class
public class Square
{
    // Attributes
    private int length = 0;

    // creating getter for length
    public int get_length()
    {
        return length;
    }

    // creating setter for length
    public void set_length(int length)
    {
        this.length = length;
    }

    // creating getter function for area calculation
    public int get_area()
    {
        return length * length;
    }
}