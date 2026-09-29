public  class Mago : Combatiente
{

    public int Mana { get; private set; }


    public Mago(string nombre, int vida = 100, int mana = 10): base(nombre, vida)
    {
        Mana = mana;
    }

    public override int CalcularAtaque()
    {
        if (Mana >= 5)
        {
            Mana -= 5;
            return 30;
        }

        return 8;
    }
    public override string ToString()
    {
        return $"El mago: {Nombre} Vida: {Vida} Mana: {Mana}";
    }

}