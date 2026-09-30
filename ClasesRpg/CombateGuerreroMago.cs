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

    public CombateGuerreroMago(Guerrero c1, Mago c2) : base(c1, c2)
    {
        VerEstados();
        if (c1.Atacar(c2))
        {
            VerEstados();
            if (c2.Atacar(c1))
            {
                VerEstados();
                if (c2.Atacar(c1))
                {
                    VerEstados();
                    if (c2.Atacar(c1))
                        VerEstados();
                }                    
            }
        }
        else 
        {
            VerEstados();
        }
        
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