using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {
            Guerrero guerrero = new Guerrero("Antonio");
            Mago mago = new Mago("Maria");
            CombateGuerreroMago combate = new CombateGuerreroMago(guerrero, mago);            
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }        
    }
}
