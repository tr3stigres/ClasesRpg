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
    public void Atacar(Combatiente objetivo)
    {
        if (Vida > 0)
            objetivo.Recibir(CalcularAtaque());
    }

    private void Recibir(int dolor)
    {
        Vida = Math.Max(0, Vida - dolor);
    }


    public abstract string ToString();

}