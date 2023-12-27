namespace ImperialConversion;

class Program
{
    static void Main()
    {
        ConvertozToGrams oz2g = new ConvertozToGrams();
        ConvertPintsToLitres pt2lr = new ConvertPintsToLitres();
        oz2g.set_oz();
        oz2g.calc_grams();
        oz2g.print_grams();

        pt2lr.set_pint();
        pt2lr.calc_litres();
        pt2lr.print_litres();
    }
}