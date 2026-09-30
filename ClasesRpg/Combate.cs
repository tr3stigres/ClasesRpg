public abstract class Combate
{

    public Combatiente Combatiente1 { get; }
    public Combatiente Combatiente2 { get; }

    protected Combate(Combatiente c1, Combatiente c2)
    {
        Combatiente1 = c1;
        Combatiente2 = c2;
    }

    public abstract string ToString();
    public abstract void VerEstados();

}