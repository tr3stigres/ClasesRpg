public abstract class Combatiente
{
    public string Nombre { get; }
    public int Vida { get; private set; }

    protected Combatiente(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public abstract int CalcularAtaque();
    public bool Atacar(Combatiente objetivo)
    {
        if (Vida > 0 && objetivo.Vida > 0)
            objetivo.Recibir(CalcularAtaque());

        return (Vida > 0 && objetivo.Vida > 0);
    }

    private void Recibir(int dolor)
    {
        Vida = Math.Max(0, Vida - dolor);
    }


    public abstract string ToString();

}