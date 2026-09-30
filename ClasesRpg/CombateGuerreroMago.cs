using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesRpg
{
    internal class CombateGuerreroMago
    {
    }
}

public class CombateGuerreroMago : Combate
{

    public CombateGuerreroMago(Combatiente guerrero, Combatiente mago) : base(guerrero, mago)
    {
        guerrero.Atacar(mago);
        VerEstados();
        mago.Atacar(guerrero);
        VerEstados();
        mago.Atacar(guerrero);
        VerEstados();
        mago.Atacar(guerrero);
        VerEstados();
    }

    public override void VerEstados()
    {
        Console.WriteLine($"\n{Combatiente1.ToString()}");
        Console.WriteLine($"{Combatiente2.ToString()}\n");
    }

    public override string ToString()
    {
        return "Combate entre un guerrero y un mago";
    }

}