public class Guerrero : Combatiente
{
    public Guerrero(string nombre, int vida = 100) : base(nombre, vida)
    {        
    }

    public override int CalcularAtaque()
    {
        return 25;
    }
    public override string ToString()
    {
        return $"El guerrero: {Nombre} Vida: {Vida}";
    }

}