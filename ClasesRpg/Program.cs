using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {
            Guerrero guerrero = new Guerrero("Antonio");
            Mago mago = new Mago("Maria");

            VerEstados(guerrero, mago);
            guerrero.Atacar(mago);
            VerEstados(guerrero, mago);
            mago.Atacar(guerrero);
            VerEstados(guerrero, mago);
            mago.Atacar(guerrero);
            VerEstados(guerrero, mago);
            mago.Atacar(guerrero);
            VerEstados(guerrero, mago);

        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }

        
    }

    public static void VerEstados(Guerrero guerrero, Mago mago)
    {
        Console.WriteLine($"\n{guerrero.ToString()}");
        Console.WriteLine($"{mago.ToString()}\n");
    }


}
